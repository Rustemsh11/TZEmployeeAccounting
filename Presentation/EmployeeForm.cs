using AutoMapper;
using Contracts;
using Entity;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class EmployeeForm : Form
    {
        private readonly IRepositoryManager _repositoryManager;
        private List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
        private List<DepartmentDTO> departmentDTOs = new List<DepartmentDTO>();

        Mapper mapper;
        public EmployeeForm(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
            mapper = MapperConfig.InitializeAutoMapper();
        }

        private async  void EmployeeForm_Load_1(object sender, EventArgs e)
        {
            employeeDTOs = await UpdateEmployeeDtoListAsync();
            dataGridView1.DataSource = employeeDTOs;

            var departments = await _repositoryManager.DepartmentRepository.GetAllDepartmentsAsync(false);
            departmentDTOs = mapper.Map<List<DepartmentDTO>>(departments);

            departmentComboBox.DataSource = departmentDTOs;
            departmentComboBox.ValueMember = "DepartmentId";
            departmentComboBox.DisplayMember = "Name";

            departmentFilterCB.DataSource = departmentDTOs;
            departmentFilterCB.ValueMember = "DepartmentId";
            departmentFilterCB.DisplayMember = "Name";
        }

        
        

        

        private string GetCountSearchResult(int count)
        {
            return $"Найдено: {count} сотрудников";
        }

        private async void addEmpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee()
                {
                    Fio = fioTextBox.Text.Trim(),
                    TabelNumber = numTabelTextBox.Text.Trim(),
                    Position = positionTextBox.Text.Trim(),
                    DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue),
                    Phone = phoneTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    EmploymentDate = dateEmploymentPicker.Value,
                    RecordState = RecordState.Active
                };
                _repositoryManager.EmployeeRepository.CreateEmployee(employee);
                await _repositoryManager.SaveAsync();
                dataGridView1.DataSource = await UpdateEmployeeDtoListAsync();
                label10.Text = "Сотрудник добавлен";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }

        }
        private async Task<List<EmployeeDTO>> UpdateEmployeeDtoListAsync()
        {
            var employyes = await _repositoryManager.EmployeeRepository.GetAllEmployeesAsync(false);
            return mapper.Map<List<EmployeeDTO>>(employyes);
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Прежде чем уволить выберите сотрудника?");
                    return;
                }
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeId"].Value;
                var emp = await _repositoryManager.EmployeeRepository.GetEmployeeAsync(employeeId, true);
                emp.TerminationDate = DateTime.Now;
                _repositoryManager.EmployeeRepository.UpdateEmployee(emp);
                await _repositoryManager.SaveAsync();
                MessageBox.Show($"Сотрудник {emp.Fio} уволен", "Внимание");
                dataGridView1.DataSource = await UpdateEmployeeDtoListAsync();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        

        private  async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Прежде чем удалить выберите запись выберите поле");
                    return;
                }
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeId"].Value;
                var emp = await _repositoryManager.EmployeeRepository.GetEmployeeAsync(employeeId, true);

                //получаем все подразделения где сотрудник руководитель и удаляем их
                var departments = await _repositoryManager.DepartmentRepository.GetBossEmployeeDepartmnet(employeeId, true);
                foreach (var item in departments)
                {
                    item.BossId = null;
                    item.Boss = null;
                    _repositoryManager.DepartmentRepository.UpdateDepartment(item);
                }

                _repositoryManager.EmployeeRepository.DeleteEmployee(emp);
                await _repositoryManager.SaveAsync();
                MessageBox.Show($"Сотрудник {emp.Fio} удален", "Внимание");
                dataGridView1.DataSource = await UpdateEmployeeDtoListAsync();
                EmployeeForm_Load_1(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            if (!nameSearchRB.Checked && !tabelSearchRB.Checked)
            {
                MessageBox.Show("Выберите критерий поиска", "Внимание");
                return;
            }
            if (nameSearchRB.Checked)
            {
                string input = searchInput.Text.ToString().ToLower().Trim();
                var result = employeeDTOs.Where(c => c.Fio.ToLower().Contains(input)).ToList();
                label10.Text = GetCountSearchResult(result.Count);
                dataGridView1.DataSource = result;
            }
            else if (tabelSearchRB.Checked)
            {
                string input = searchInput.Text.ToString().ToLower().Trim();
                var result = employeeDTOs.Where(c => c.TabelNumber.Trim().ToLower().Contains(input)).ToList();
                label10.Text = GetCountSearchResult(result.Count);
                dataGridView1.DataSource = result;
            }
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!dateemplFilterRB.Checked && !dateTerminFilterRB.Checked && !departmentFilterRB.Checked)
                {
                    MessageBox.Show("Выберите критерий выборки", "Внимание");
                    return;
                }

                if (dateemplFilterRB.Checked)
                {
                    var result = employeeDTOs.Where(c => DateTime.ParseExact(c.EmploymentDate.ToString().Substring(0, 10), "dd/MM/yyyy", null) >= firstDatePicker.Value && DateTime.ParseExact(c.EmploymentDate.ToString().Substring(0, 10), "dd/MM/yyyy", null) < lastTimePicker.Value).ToList();
                    label10.Text = GetCountSearchResult(result.Count);
                    dataGridView1.DataSource = result;
                }
                else if (dateTerminFilterRB.Checked)
                {
                    var result = employeeDTOs.Where(c => c.TerminationDate != null && DateTime.ParseExact(c.TerminationDate.ToString().Substring(0, 10), "dd/MM/yyyy", null) >= firstDatePicker.Value && DateTime.ParseExact(c.TerminationDate.ToString().Substring(0, 10), "dd/MM/yyyy", null) < lastTimePicker.Value).ToList();
                    label10.Text = GetCountSearchResult(result.Count);
                    dataGridView1.DataSource = result;
                }
                else if (departmentFilterRB.Checked)
                {
                    var department = departmentFilterCB.Text.ToLower().Trim();
                    var result = employeeDTOs.Where(c => c.Department.ToLower().Trim().Contains(department)).ToList();
                    label10.Text = GetCountSearchResult(result.Count);
                    dataGridView1.DataSource = result;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
