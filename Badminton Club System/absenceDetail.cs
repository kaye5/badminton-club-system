﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Badminton_Club_System
{
    public partial class absenceDetail : Form
    {
        String today;
        int col = 0;
        public absenceDetail(String today)
        {
            InitializeComponent();
            this.today = today;
            updateData();
        }

        private void absenceDetailListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                absenceDetailCMS.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void updateData()
        {
            table.Clear();
            absenceDetailCB.Items.Clear();
            db.sql = $"select max(meeting_count) from meeting where `month` = '{today}'";
            db.addCMD();
            MySqlDataReader r = db.cmd.ExecuteReader();
            while (r.Read())
            {
                col = r.GetInt16(0);
            }
            createCol();
            r.Dispose();
            db.disposeCmd();

            db.sql = "select a.member_id , mem.`name` , m.meeting_count,a.`status` from `absence` a " +
                        "inner join `meeting` m on a.meeting_id = m.id " +
                        "inner join `member` mem on a.member_id = mem.nim " +
                        "where m.`month` = 'november 2019' " +
                        "order by m.meeting_count";
            db.addCMD();
            r = db.cmd.ExecuteReader();
            while (r.Read())
            {
                ListViewItem item = new ListViewItem(r.GetString(0));
                item.SubItems.Add(r.GetString(1));
                if (r.GetInt16(2) == 1)
                    item.SubItems.Add(r.GetString(3));
                else
                {
                    int i = 0;
                    foreach(ListViewItem el in table.Items)
                    {
                        if (el.SubItems[0].Text == r.GetString(0))
                            table.Items[i].SubItems.Add(r.GetString(3));
                        i++;
                    }
                    continue;
                }
                table.Items.Add(item);
            }
            r.Dispose();
            db.disposeCmd();
        }

        private void createCol()
        {
            table.Columns.Add("NIM",145);
            table.Columns.Add("Name", 145);
            for (int i = 0; i < col; i++)
            {
                table.Columns.Add("Meeting " + (i + 1).ToString(), 100);
                absenceDetailCB.Items.Add("Meeting " + (i + 1).ToString());
            }
            absenceDetailCB.SelectedIndex = 0;
        }

        private void newMeetinBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(today);
            String[] date = today.Split();
            Console.WriteLine(date[0]);
            Console.WriteLine(date[1]);
            String count = (col + 1).ToString();
            db.sql = $"insert into `meeting` values('{date[0]+date[1]+count}','{today}',{col+1})";
            db.addCMD();
            db.cmd.ExecuteNonQuery();
            db.disposeCmd();
            db.sql = $"insert into `absence`(`id`,`member_id`,`meeting_id`) select concat('{date[0]+date[1] + count}',m.nim) , m.nim , '{date[0]+date[1] + count}' from `member` m";
            db.addCMD();
            Console.WriteLine(db.sql);
            db.cmd.ExecuteNonQuery();
            updateData();
        }
    }
}
