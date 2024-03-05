using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TeamManagement.DTO;

namespace TeamManagement
{

    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source= 192.168.1.20;Initial Catalog=TeamManagement;Persist Security Info=True;User ID=sa;Password=123456");
        public Form1()
        {
            InitializeComponent();
        }
        private bool sortAscending = false;
        private List<TeamDTO> dataList;
        private void GetAllTeam()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            try
            {
                var query =  from team in dc.GetTable<Team_tb>()
                             join department in dc.GetTable<Department_tb>()
                             on team.department_id equals department.department_id
                             select new TeamDTO
                             {
                                 TeamId = team.team_id,
                                 TeamName = team.team_name,
                                 DepartmentName = department.department_name
                             };
                dataGridView1.DataSource = query.ToList();
                dataList = query.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxMaTeam.Enabled = false;
            textBoxTenTeam.Enabled = false;
            comboBoxBoPhan.Enabled = false;

            buttonThem.Visible = true;
            buttonSua.Visible = true;
            buttonXoa.Visible = true;

            buttonXacNhan.Visible = false;
            buttonHuy.Visible = false;

            buttonCapNhat.Visible = false;
            buttonHuyEdit.Visible = false;

            GetAllTeam();
            GetDepartments();

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
        }

        private void ClearTextBox()
        {
            textBoxMaTeam.Text = "";
            textBoxTenTeam.Text = "";
        }

        private void GetDepartments()
        {

            DataClasses1DataContext dc = new DataClasses1DataContext();
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            textBoxMaTeam.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTenTeam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            { 
                var departments = (from d in dc.GetTable<Department_tb>()
                                   select new
                                   {
                                       departmentId = d.department_id,
                                       departmentName = d.department_name
                                   }).ToList();
                comboBoxBoPhan.DataSource = departments;
                comboBoxBoPhan.DisplayMember = "departmentName";
                comboBoxBoPhan.ValueMember = "departmentId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            GetDepartments();
            textBoxMaTeam.Enabled = true;
            textBoxTenTeam.Enabled = true;
            comboBoxBoPhan.Enabled = true;
            ClearTextBox();

            buttonThem.Visible = false;
            buttonSua.Visible = false;
            buttonXoa.Visible = false;

            buttonXacNhan.Visible = true;
            buttonHuy.Visible = true;

            buttonCapNhat.Visible = false;
            buttonHuyEdit.Visible = false;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxMaTeam.Enabled = false;
            textBoxTenTeam.Enabled = false;
            comboBoxBoPhan.Enabled = false;

            buttonThem.Visible = true;
            buttonSua.Visible = true;
            buttonXoa.Visible = true;

            buttonXacNhan.Visible = false;
            buttonHuy.Visible = false;
            
            buttonCapNhat.Visible = false;
            buttonHuyEdit.Visible = false;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            try
            { 
                Team_tb newTeam = new Team_tb();
                newTeam.team_id = textBoxMaTeam.Text;
                newTeam.team_name = textBoxTenTeam.Text;
                newTeam.department_id = comboBoxBoPhan.SelectedValue.ToString();
                dc.Team_tbs.InsertOnSubmit(newTeam);
                dc.SubmitChanges();

                GetAllTeam();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            try
            {
                textBoxMaTeam.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTenTeam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                var departmeniId = dc.GetTable<Team_tb>().SingleOrDefault(d => d.team_id == textBoxMaTeam.Text).department_id;
                var departmment = dc.GetTable<Department_tb>().FirstOrDefault(s => s.department_id == departmeniId);
                comboBoxBoPhan.SelectedValue = departmment.department_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            textBoxMaTeam.Enabled = false;
            textBoxTenTeam.Enabled = true;
            comboBoxBoPhan.Enabled = true;

            buttonThem.Visible = false;
            buttonSua.Visible = false;
            buttonXoa.Visible = false;

            buttonXacNhan.Visible = false;
            buttonHuy.Visible = false;

            buttonCapNhat.Visible = true;
            buttonHuyEdit.Visible = true;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            try
            {
                var team = dc.Team_tbs.FirstOrDefault(t => t.team_id.Equals(textBoxMaTeam.Text));
                team.team_name = textBoxTenTeam.Text;
                team.department_id = comboBoxBoPhan.SelectedValue.ToString();
                dc.SubmitChanges();

                GetAllTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataClasses1DataContext dc = new DataClasses1DataContext(con);
                try
                {
                    var team = dc.Team_tbs.FirstOrDefault(t => t.team_id.Equals(dataGridView1.CurrentRow.Cells[0].Value));
                    dc.Team_tbs.DeleteOnSubmit(team);
                    dc.SubmitChanges();
                    GetAllTeam();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            string searchText = textBoxTimKiem.Text.Trim();
            
            if (string.IsNullOrEmpty(searchText))
            {
                GetAllTeam();
            }
            else
            {
                try
                {
                    var filteredData = (from team in dc.GetTable<Team_tb>()
                                        join department in dc.GetTable<Department_tb>() on team.department_id equals department.department_id
                                        select new
                                        {
                                            TeamId = team.team_id,
                                            TeamName = team.team_name.ToLower(),
                                            DepartmentName = department.department_name
                                        })
                          .Where(team => team.TeamName.Contains(searchText));
                    dataGridView1.DataSource = filteredData.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

            using (var saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook (*.xlsx)|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {

                            DataTable dataTable = new DataTable();

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                dataTable.Columns.Add(column.Name, column.ValueType);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                DataRow dataRow = dataTable.NewRow();
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    dataRow[i] = row.Cells[i].Value;
                                }
                                dataTable.Rows.Add(dataRow);
                            }
                            var worksheet = workbook.Worksheets.Add(dataTable, "Report");
                            //int rows = dataGridView1.Rows.Count;
                            //int columns = dataGridView1.Columns.Count;

                            //for (int i = 0; i < rows; i++)
                            //{
                            //    for (int j = 0; j < columns; j++)
                            //    {
                            //        string  cellValue = dataGridView1[j, i].Value.ToString();

                            //        worksheet.Cell(i + 1, j + 1).Value = cellValue;
                            //    }
                            //}

                            workbook.SaveAs(saveFileDialog.FileName);

                            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string propertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            if (sortAscending)
                dataList = dataList.OrderBy(item => item.GetType().GetProperty(propertyName)?.GetValue(item, null)).ToList();
            else
                dataList = dataList.OrderByDescending(item => item.GetType().GetProperty(propertyName)?.GetValue(item, null)).ToList();
            sortAscending = !sortAscending;
            dataGridView1.DataSource = dataList;
        }
    }
}
