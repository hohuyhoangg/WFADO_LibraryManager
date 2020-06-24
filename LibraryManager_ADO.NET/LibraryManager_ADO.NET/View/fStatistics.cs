using LibraryManager_ADO.NET.Controller;
using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager_ADO.NET.View
{
    public partial class fStatistics : Form
    {
        private BookShowDTO loginBookShowDTO;
        public BookShowDTO LoginBookShowDTO
        {
            get => loginBookShowDTO;
            set
            {
                this.loginBookShowDTO = value;
            }
        }
        public fStatistics(BookShowDTO bookShowDTO)
        {
            InitializeComponent();
            this.LoginBookShowDTO = bookShowDTO;
        }
        BindingSource BindingSourceBookBorrow = new BindingSource();

        private void fStatistics_Load(object sender, EventArgs e)
        {
            if(loginBookShowDTO != null)
            {
                txbBookName.Text = LoginBookShowDTO.Title;
                txbCount.Text = loginBookShowDTO.NumberCount.ToString();
                txbIdBook.Text = loginBookShowDTO.Id;
                List<StatisticsDTO> statisticsDTOs = StatisticsDAO.Instance.GetListBookBorrow();
                BindingSourceBookBorrow.DataSource = statisticsDTOs;
                dgvBookS.DataSource = BindingSourceBookBorrow;
                int temp = statisticsDTOs.Count;
                txbNUmber.Text = (LoginBookShowDTO.NumberCount - temp).ToString();
            }
        }
    }
}
