using AutoMapper;
using Contracts;
using Entity;
using Shared;
using System.Data;

namespace Presentation
{
    public partial class DepartmentsForm : Form
    {
        private readonly IRepositoryManager _repositoryManager;
        private List<DepartmentDTO> departmentDTOs;
        private List<EmployeeDTO> employeeDTOs;
        private Mapper mapper;
        public DepartmentsForm(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
            mapper = MapperConfig.InitializeAutoMapper();
        }
        private async void DepartmentsForm_Load(object sender, EventArgs e)
        {
            departmentDTOs = await UpdateDepartmentDtoListAsync();
            dataGridView1.DataSource = departmentDTOs;

            var employee = await _repositoryManager.EmployeeRepository.GetAllEmployeesAsync(false);
            employeeDTOs = mapper.Map<List<EmployeeDTO>>(employee);

            mainComboBox.DataSource = departmentDTOs;
            mainComboBox.ValueMember = "DepartmentId";
            mainComboBox.DisplayMember = "Name";

            bossComboBox.DataSource = employeeDTOs;
            bossComboBox.ValueMember = "EmployeeId";
            bossComboBox.DisplayMember = "Fio";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(!nameSearchRB.Checked && !idSearchRB.Checked)
                {
                    MessageBox.Show("Выберите критерий поиска", "Внимание");
                    return;
                }

                if (nameSearchRB.Checked)
                {
                    string input = searchInput.Text.ToString().ToLower().Trim();
                    var result = departmentDTOs.Where(c => c.Name.ToLower().Contains(input)).ToList();
                    label10.Text = GetCountSearchResult(result.Count);
                    dataGridView1.DataSource = result;
                }
                else if (idSearchRB.Checked)
                {
                    int input = Convert.ToInt32(searchInput.Text.ToString().ToLower().Trim());
                    var result = departmentDTOs.Where(c => c.DepartmentId == input).ToList();
                    label10.Text = GetCountSearchResult(1);
                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private async void addEmpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var department = new Department()
                {
                    Name = nameTextBox.Text.Trim(),
                    BossId = (int)bossComboBox.SelectedValue,
                    MainDepartmentid = (int)mainComboBox.SelectedValue,
                };
                _repositoryManager.DepartmentRepository.CreateDepartment(department);
                await _repositoryManager.SaveAsync();
                dataGridView1.DataSource = await UpdateDepartmentDtoListAsync();
                MessageBox.Show($"Добавлено подразделение: {department.Name}");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Выберите поле которое хотите удалить");
                    return;
                }

                var department = await _repositoryManager.DepartmentRepository.GetDepartmentAsync((int)dataGridView1.SelectedRows[0].Cells["DepartmentId"].Value, true);
                //получем все дочерние элементы подразделения и  поле головной подразделение обнуляем
                var child = await _repositoryManager.DepartmentRepository.GetChildDepartmentAsync(department.DepartmentId, true);
                foreach (var item in child)
                {
                    var childDepartment = mapper.Map<Department>(item);
                    childDepartment.MainDepartmentid = null;
                    childDepartment.MainDepartment = null;
                    _repositoryManager.DepartmentRepository.UpdateDepartment(childDepartment);
                }
                _repositoryManager.DepartmentRepository.DeleteDepartment(department);
                await _repositoryManager.SaveAsync();
                dataGridView1.DataSource = await UpdateDepartmentDtoListAsync();
                MessageBox.Show($"Вы удалили подразделение {department.Name}");
                DepartmentsForm_Load(null, null);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }

        }
        private string GetCountSearchResult(int count)
        {
            return $"Найдено {count} подразделении";
        }

        private async Task<List<DepartmentDTO>> UpdateDepartmentDtoListAsync()
        {
            var deparments = await _repositoryManager.DepartmentRepository.GetAllDepartmentsAsync(false);
            return mapper.Map<List<DepartmentDTO>>(deparments);
        }
    }
}
