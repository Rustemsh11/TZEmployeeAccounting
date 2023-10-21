using Contracts;
using Entity;
using ExcelDataReader;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FillEmployeeForms : Form
    {
        private readonly IRepositoryManager _repositoryManager;
        private string path = string.Empty;
        private DataTableCollection tableCollection = null;
        private List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
        private List<DepartmentDTO> departmentDTOs = new List<DepartmentDTO>();
        public FillEmployeeForms(IRepositoryManager repositoryManager)
        {
            InitializeComponent();
            _repositoryManager = repositoryManager;
        }


        private void сhooseFileButton_Click(object sender, EventArgs e)
        {

        }
        private void OpenExcelFile(string path)
        {
            try
            {
                using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var configuration = new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = x => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = false
                            }
                        };
                        DataSet result = reader.AsDataSet(configuration);
                        for (int i = 1; i < result.Tables[0].Rows.Count; i++)
                        {


                            var employee = new EmployeeDTO()
                            {
                                EmployeeId = Convert.ToInt32(result.Tables[0].Rows[i][0]),
                                Fio = result.Tables[0].Rows[i][1].ToString(),
                                TabelNumber = result.Tables[0].Rows[i][2].ToString(),
                                Position = result.Tables[0].Rows[i][3].ToString(),
                                Department = result.Tables[0].Rows[i][4].ToString(),
                                Email = result.Tables[0].Rows[i][5].ToString(),
                                Phone = result.Tables[0].Rows[i][6].ToString(),
                                EmploymentDate = result.Tables[0].Rows[i][7].ToString(),
                                TerminationDate = result.Tables[0].Rows[i][8].ToString()
                            };
                            employeeDTOs.Add(employee);
                        }
                        for (int i = 1; i < result.Tables[1].Rows.Count; i++)
                        {


                            var department = new DepartmentDTO()
                            {

                                DepartmentId = Convert.ToInt32(result.Tables[1].Rows[i][0]),
                                Name = result.Tables[1].Rows[i][1].ToString(),
                                MainDepartment = result.Tables[1].Rows[i][2].ToString() ?? ""
                            };
                            departmentDTOs.Add(department);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void сhooseFileButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                var fileDIalog = openFileDialog1.ShowDialog();
                if (fileDIalog == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                    OpenExcelFile(path);
                    dataGridView1.DataSource = employeeDTOs;
                    dataGridView2.DataSource = departmentDTOs;
                }
                else
                {
                    throw new Exception("Файл не выбран");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private async void saveButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                foreach (var item in departmentDTOs)
                {
                    var department = new Department()
                    {
                        //DepartmentId = item.DepartmentId,
                        Name = item.Name,
                        MainDepartmentid = string.IsNullOrWhiteSpace(item.MainDepartment) ? null : Convert.ToInt32(departmentDTOs.SingleOrDefault(c => c.Name.Contains(item.MainDepartment)).DepartmentId)
                    };
                    _repositoryManager.DepartmentRepository.CreateDepartment(department);
                }
                foreach (var item in employeeDTOs)
                {
                    var employee = new Employee()
                    {
                        //EmployeeId = item.EmployeeId,
                        Fio = item.Fio,
                        DepartmentId = Convert.ToInt32(departmentDTOs.SingleOrDefault(c => c.Name.Contains(item.Department)).DepartmentId),
                        TabelNumber = item.TabelNumber,
                        Phone = item.Phone,
                        Position = item.Position,
                        Email = item.Email,
                        EmploymentDate = DateTime.ParseExact(item.EmploymentDate.ToString().Substring(0, 10), "dd/MM/yyyy", null),
                        TerminationDate = string.IsNullOrWhiteSpace(item.TerminationDate) ? null : DateTime.ParseExact(item.TerminationDate.ToString().Substring(0, 10), "dd/MM/yyyy", null)
                    };
                    _repositoryManager.EmployeeRepository.CreateEmployee(employee);
                }
                await _repositoryManager.SaveAsync();
                label3.Text = "Сохранение прошло успешно";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка");
            }

        }        
    }
}
