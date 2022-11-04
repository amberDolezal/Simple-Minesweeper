using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adolezalMinesweeper
{
    public partial class Cell : UserControl
    {
        public event EventHandler<CellClickEventArgs> CellClick;
        Panel background = new Panel();
        Label label = new Label();
        Button button = new Button();
        Size cellSize = new Size(60, 60);
        int x;
        int y;

        public Cell()
        {
            InitializeComponent();
            this.Size = cellSize;
            background.Size = this.Size;
            label.Size = cellSize;
            label.BackColor = Color.PowderBlue;
            label.BorderStyle = BorderStyle.Fixed3D;
            button.Size = this.Size;
            button.BackColor = Color.SteelBlue;
            button.Click += ButtonClick_EventHandler;
            this.Controls.Add(button);
            this.Controls.Add(label);
            this.Controls.Add(background);
        }
        /// <summary>
        /// Makes button not visible when clicked, pass col and row through, calls OnCellClick fuction
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">EventArgs that pass coordinates of click</param>
        public void ButtonClick_EventHandler(object ?sender, EventArgs e)
        {
            button.Visible = false;
            CellClickEventArgs args = new CellClickEventArgs(X, Y);
            OnCellClick(this, args);
        }
        /// <summary>
        /// Raises the event on when button is clicked
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">CellClickEventArgs that pass coordinates of click</param>
        protected virtual void OnCellClick(object sender, CellClickEventArgs e)
        {
            CellClick?.Invoke(sender, e);
        }

        public void PerformClick()
        {
            button.PerformClick();
        }

        //Getters and setters 
        public Size CellSize { get => cellSize; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Color BackgroundColor
        {
            get => background.BackColor; 
            set => background.BackColor = value;   
        }

        public String PanelText
        {
            get => label.Text;
            set => label.Text = value;
        }

        public bool buttonVisibility
        {
            get => button.Visible;
        }   
    }
}
