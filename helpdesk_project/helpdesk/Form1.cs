using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpdesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        int id = -1;

        PgSQL pgsql = null;


        DataTable table = null;
        DataTable category = null;
        DataTable client = null;
        DataTable priority = null;
        DataTable status = null;
        DataTable post = null;
        DataTable department = null;
        DataTable oper = null;
        DataTable implementer = null;

        string title = "Заявки";

        void Start()
        {
            pgsql = new PgSQL("Server=localhost;Port=5432;Database=helpdesk;User Id=postgres;Password=1;");
            grid.MultiSelect = false;
            getRecordsForComboBox();
            showTable();
        }

        void getRecordsForComboBox()
        {
            category = pgsql.OutTable("show_category");
            client = pgsql.OutTable("show_client");
            priority = pgsql.OutTable("show_priority");
            status = pgsql.OutTable("show_status");
            post = pgsql.OutTable("show_post");
            department = pgsql.OutTable("show_department");
            oper = pgsql.OutTable("show_worker");
            implementer = pgsql.OutTable("show_worker");

            reqCatBox.DataSource = category.DefaultView;
            reqCatBox.DisplayMember = "Наименование";
            reqCatBox.ValueMember = "№";

            reqClientBox.DataSource = client.DefaultView;
            reqClientBox.DisplayMember = "Имя";
            reqClientBox.ValueMember = "№";

            reqPrioBox.DataSource = priority.DefaultView;
            reqPrioBox.DisplayMember = "Наименование";
            reqPrioBox.ValueMember = "№";

            reqStatBox.DataSource = status.DefaultView;
            reqStatBox.DisplayMember = "Наименование";
            reqStatBox.ValueMember = "№";

            workPostBox.DataSource = post.DefaultView;
            workPostBox.DisplayMember = "Наименование";
            workPostBox.ValueMember = "№";

            workDepBox.DataSource = department.DefaultView;
            workDepBox.DisplayMember = "Наименование";
            workDepBox.ValueMember = "№";

            reqOperBox.DataSource = oper.DefaultView;
            reqOperBox.DisplayMember = "Имя";
            reqOperBox.ValueMember = "№";

            reqImpBox.DataSource = implementer.DefaultView;
            reqImpBox.DisplayMember = "Имя";
            reqImpBox.ValueMember = "№";
        }

        private void showTable()
        {
            switch (title)
            {
                case "Заявки":
                    table = pgsql.OutTable("show_request");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Клиенты":
                    table = pgsql.OutTable("show_client");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Сотрудники":
                    table = pgsql.OutTable("show_worker");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Отделы":
                    table = pgsql.OutTable("show_department");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Категории":
                    table = pgsql.OutTable("show_category");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Должность":
                    table = pgsql.OutTable("show_post");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Приоритет":
                    table = pgsql.OutTable("show_priority");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
                case "Статус":
                    table = pgsql.OutTable("show_status");
                    grid.DataSource = table.DefaultView;
                    grid.Columns[0].Visible = false;
                    break;
            }
        }

        private void editForRow()
        {
            id = -1;
            int num = grid.SelectedRows[0].Index;
            if (num == -1) throw new Exception("Не выбрана строка для изменения!");
            id = Convert.ToInt32(table.Rows[num][0]);
            switch (title)
            {
                case "Заявки":
                    reqNameBox.Text = table.Rows[num][1].ToString(); ;
                    reqDesBox.Text = table.Rows[num][2].ToString(); ;
                    reqRecBox.Text = table.Rows[num][3].ToString(); ;
                    reqDeadBox.Text = table.Rows[num][4].ToString(); ;
                    reqCatBox.Text = table.Rows[num][5].ToString(); ;
                    reqOperBox.Text = table.Rows[num][6].ToString(); ;
                    reqClientBox.Text = table.Rows[num][7].ToString(); ;
                    reqPrioBox.Text = table.Rows[num][8].ToString(); ;
                    reqImpBox.Text = table.Rows[num][9].ToString(); ;
                    reqStatBox.Text = table.Rows[num][10].ToString(); ;
                    break;
                case "Клиенты":
                    clientNameBox.Text = table.Rows[num][1].ToString(); ;
                    clientAddrBox.Text = table.Rows[num][2].ToString(); ;
                    clientPhonBox.Text = table.Rows[num][3].ToString(); ;
                    clientEmailBox.Text = table.Rows[num][4].ToString(); ;
                    break;
                case "Сотрудники":
                    workNameBox.Text = table.Rows[num][1].ToString(); ;
                    workAddrBox.Text = table.Rows[num][2].ToString(); ;
                    workPhonBox.Text = table.Rows[num][3].ToString(); ;
                    workDepBox.Text = table.Rows[num][4].ToString(); ;
                    workPostBox.Text = table.Rows[num][5].ToString(); ;
                    break;
                case "Отделы":
                    depNameBox.Text = table.Rows[num][1].ToString(); ;
                    depPhonBox.Text = table.Rows[num][2].ToString(); ;
                    depEmailBox.Text = table.Rows[num][3].ToString(); ;
                    break;
                case "Категории":
                    catNameBox.Text = table.Rows[num][1].ToString(); ;
                    catDesBox.Text = table.Rows[num][2].ToString(); ;
                    break;
                case "Должность":
                    postNameBox.Text = table.Rows[num][1].ToString(); ;
                    postDesBox.Text = table.Rows[num][2].ToString(); ;
                    break;
                case "Приоритет":
                    prioNameBox.Text = table.Rows[num][1].ToString(); ;
                    break;
                case "Статус":
                    statNameBox.Text = table.Rows[num][1].ToString(); ;
                    break;
            }
            отменитьToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;
            добавитьToolStripMenuItem.Enabled = false;
            grid.Enabled = false;
        }

        private void saveEditForRecord()
        {
            switch (title)
            {
                case "Заявки":
                    pgsql.AddEditRequest("update_request", reqNameBox.Text, reqDesBox.Text, reqRecBox.Text, reqDeadBox.Text, Convert.ToInt32(reqOperBox.SelectedValue), Convert.ToInt32(reqCatBox.SelectedValue), Convert.ToInt32(reqClientBox.SelectedValue), Convert.ToInt32(reqPrioBox.SelectedValue), Convert.ToInt32(reqImpBox.SelectedValue), Convert.ToInt32(reqStatBox.SelectedValue), id);
                    break;
                case "Клиенты":
                    pgsql.AddEditClient("update_client", clientNameBox.Text, clientAddrBox.Text, clientPhonBox.Text, clientEmailBox.Text, id);
                    break;
                case "Сотрудники":
                    pgsql.AddEditWorker("update_worker", workNameBox.Text, workAddrBox.Text, workPhonBox.Text, Convert.ToInt32(workDepBox.SelectedValue), Convert.ToInt32(workPostBox.SelectedValue), id);
                    break;
                case "Отделы":
                    pgsql.AddEditDepartment("update_department", depNameBox.Text, depPhonBox.Text, depEmailBox.Text,id);
                    break;
                case "Категории":
                    pgsql.AddEditCategory("update_category", catNameBox.Text, catDesBox.Text, id);
                    break;
                case "Должность":
                    pgsql.AddEditPost("update_post", postNameBox.Text, postDesBox.Text, id);
                    break;
                case "Приоритет":
                    pgsql.AddEditPriority("update_priority", prioNameBox.Text, id);
                    break;
                case "Статус":
                    pgsql.AddEditStatus("update_status", statNameBox.Text, id);
                    break;
            }
            отменитьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            добавитьToolStripMenuItem.Enabled = true;
            grid.Enabled = true;
            Cancel();
            getRecordsForComboBox();
            showTable();
            id = -1;
        }

        private void Cancel()
        {
            switch (title)
            {
                case "Заявки":
                    reqNameBox.Text = null;
                    reqStatBox.Text = null;
                    reqPrioBox.Text = null;
                    reqOperBox.Text = null;
                    reqImpBox.Text = null;
                    reqDesBox.Text = null;
                    reqDeadBox.Text = null;
                    reqClientBox.Text = null;
                    reqCatBox.Text = null;
                    reqRecBox.Text = null;
                    break;
                case "Клиенты":
                    clientNameBox.Text = null;
                    clientAddrBox.Text = null;
                    clientPhonBox.Text = null;
                    clientEmailBox.Text = null;
                    break;
                case "Сотрудники":
                    workNameBox.Text = null;
                    workAddrBox.Text = null;
                    workPhonBox.Text = null;
                    workDepBox.Text = null;
                    workPostBox.Text = null;
                    break;
                case "Отделы":
                    depNameBox.Text = null;
                    depPhonBox.Text = null;
                    depEmailBox.Text = null;
                    break;
                case "Категории":
                    catNameBox.Text = null;
                    catDesBox.Text = null;
                    break;
                case "Должность":
                    postNameBox.Text = null;
                    postDesBox.Text = null;
                    break;
                case "Приоритет":
                    prioNameBox.Text = null;
                    break;
                case "Статус":
                    statNameBox.Text = null;
                    break;
            }
            отменитьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            добавитьToolStripMenuItem.Enabled = true;
            grid.Enabled = true;
            id = -1;
        }

        private void addRecord()
        {
            switch (title)
            {
                case "Заявки":
                    pgsql.AddEditRequest("insert_request", reqNameBox.Text, reqDesBox.Text, reqRecBox.Text, reqDeadBox.Text, Convert.ToInt32(reqOperBox.SelectedValue), Convert.ToInt32(reqCatBox.SelectedValue), Convert.ToInt32(reqClientBox.SelectedValue), Convert.ToInt32(reqPrioBox.SelectedValue), Convert.ToInt32(reqImpBox.SelectedValue), Convert.ToInt32(reqStatBox.SelectedValue));
                    break;
                case "Клиенты":
                    pgsql.AddEditClient("insert_client", clientNameBox.Text, clientAddrBox.Text, clientPhonBox.Text, clientEmailBox.Text);
                    break;
                case "Сотрудники":
                    pgsql.AddEditWorker("insert_worker", workNameBox.Text, workAddrBox.Text, workPhonBox.Text, Convert.ToInt32(workDepBox.SelectedValue), Convert.ToInt32(workPostBox.SelectedValue));
                    break;
                case "Отделы":
                    pgsql.AddEditDepartment("insert_department", depNameBox.Text, depPhonBox.Text, depEmailBox.Text);
                    break;
                case "Категории":
                    pgsql.AddEditCategory("insert_category", catNameBox.Text, catDesBox.Text);
                    break;
                case "Должность":
                    pgsql.AddEditPost("insert_post", postNameBox.Text, postDesBox.Text);
                    break;
                case "Приоритет":
                    pgsql.AddEditPriority("insert_priority", prioNameBox.Text);
                    break;
                case "Статус":
                    pgsql.AddEditStatus("insert_status", statNameBox.Text);
                    break;
            }
            Cancel();
            getRecordsForComboBox();
            showTable();
            id = -1;
        }

        private void deleteRecord()
        {
            id = -1;
            int num = grid.SelectedRows[0].Index;
            if (num == -1) throw new Exception("Не выбрана строка для удаления!");
            id = Convert.ToInt32(table.Rows[num][0]);
            switch (title)
            {
                case "Заявки":
                    pgsql.Del("delete_request", id);
                    break;
                case "Клиенты":
                    pgsql.Del("delete_client", id);
                    break;
                case "Сотрудники":
                    pgsql.Del("delete_worker", id);
                    break;
                case "Отделы":
                    pgsql.Del("delete_department", id);
                    break;
                case "Категории":
                    pgsql.Del("delete_category", id);
                    break;
                case "Должность":
                    pgsql.Del("delete_post", id);
                    break;
                case "Приоритет":
                    pgsql.Del("delete_priority", id);
                    break;
                case "Статус":
                    pgsql.Del("delete_status", id);
                    break;
            }
            getRecordsForComboBox();
            showTable();
            id = -1;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            title = "Заявки";
            showTable();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            title = "Клиенты";
            showTable();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            title = "Сотрудники";
            showTable();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            title = "Отделы";
            showTable();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            title = "Категории";
            showTable();
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            title = "Должность";
            showTable();
        }

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            title = "Приоритет";
            showTable();
        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            title = "Статус";
            showTable();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addRecord();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveEditForRecord();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cancel();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                editForRow();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                deleteRecord();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void reqDesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void workPostBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prioNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reqNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
