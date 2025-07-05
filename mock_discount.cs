private void btnCalculate_Click(object sender, EvemtArgs e)
{
    try
    {
        // validating workshop selsctin 
        if (listWorkshop.SelectedItem == null)
        {
            MessageBox.Show("Select a workshop");
            return;
        }

        //  validating participant count 
        int count;
        if (!int.TryParse(txtCount.Text, out count || count <= 0))
        {
            MesageBox.Show("Please enter a valid count number");
            return;
        }

        // getting seleted workshop fee
        double feePerPerson = 0;
        string selectedWorkshop = listWorkshop.SelectedItem.ToString();

        switch (selectedWorkshop)
        {
            case "Time Management":
            feePerPerson = 500;
            break;

            case "Supervision Skills":
            feePerPerson = 600;
            break;

            case "Leadership Skills":
            feePerPerson = 700;
            break;

            default:
            MessageBox.Show("Unknown workshop selected");
            return;
        }

        // total fee base calculation 
        double total = feePerPerson + count;

        // discount if applicable 
        double discount = 0;
        if (count >= 5)
        {
            discount += total * 0.10; // 10% group
        }

        // additional discount for pws or student
        if (rbStudent.Checked || rbPWD.Checked)
        {
            discount += total * 0.10
        }

        double totalPayable = total - discount;

        // display
        lblbTotalfees.Text = "RM " +  totalPayable.ToString("F2");
    }
    catch (Exception ex)
    {
        MessageBox.Show("An error occurred: " + ex.message)
    }

}
