using System;
using System.Windows.Forms;

namespace OMG_Krasniqi_Olti
{
    public class View : Form, IView
    {
        private IController controller;

        TextBox txtZahl1 = new TextBox();
        TextBox txtZahl2 = new TextBox();
        Button btnBerechnen = new Button();
        Label lblErgebnis = new Label();

        public View()
        {
            SetupUI();
        }

        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        private void SetupUI()
        {
            this.Text = "ggT Rechner";
            this.Width = 300;
            this.Height = 200;

            txtZahl1.Top = 20;
            txtZahl1.Left = 20;

            txtZahl2.Top = 50;
            txtZahl2.Left = 20;

            btnBerechnen.Text = "ggT berechnen";
            btnBerechnen.Top = 80;
            btnBerechnen.Left = 20;
            btnBerechnen.Click += ButtonGgtBerechnen_Click;

            lblErgebnis.Top = 120;
            lblErgebnis.Left = 20;
            lblErgebnis.Width = 200;

            Controls.Add(txtZahl1);
            Controls.Add(txtZahl2);
            Controls.Add(btnBerechnen);
            Controls.Add(lblErgebnis);
        }

        private void ButtonGgtBerechnen_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtZahl1.Text);
            int b = int.Parse(txtZahl2.Text);

            int ggt = controller.GgtBerechnen(a, b);
            Anzeigen(ggt);
        }

        public void Anzeigen(int ggt)
        {
            lblErgebnis.Text = "ggT = " + ggt;
        }
    }
}
