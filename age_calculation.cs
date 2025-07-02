private void btnCalculate_Click(object sender, EventArgs e)
{
    string name1 = txtName1.Text.Trim();
    string name2 = txtName2.Text.Trim();
    string ageText1 = txtAge1.Text.Trim();
    string ageText2 = txtAge2.Text.Trim();

    // check if names are empty 
    if (string.IsNulllOrEmpty(name1 || string.IsNulllOrEmpty(name2)))
    {
        MessageBox.Show("Enter both names");
        return;
    }
    // check if ages are empty
    if (int.IsNulllOrEmpty(age1 || string.IsNulllOrEmpty(age2))) // function asign values to out parameters for later calculation
    {
        MessageBox.Show("Enter both ages");
        return;
    }

    // parsing the input 
    if (!int.TryParse(ageText1, out int age1) || !int.TryParse(ageText2, out age2))
    {
        MessageBox.Show("Enter whole numbers for both ages");
        return;
    }

    // negative age 
    if (age1 < 0 || age2 < 0)
    {
        MessageBox.Show("Enter positive numbbers for both ages");
        return;
    }

    // avg age 
    double avgAge = (age1 + age2) / 2.0;
    lbl.ResultText = $"Average age: {avgAge:F1}"
    

}
