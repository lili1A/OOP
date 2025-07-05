int myage;
if (strin g.IsNullOrWhiteSpace(textAge.Text))
{
    MessageBox.Show("Empty")
}
else if (!int.TryParse(textAge.Text, out myage))
{
   MessageBox.Show("Empty")
}
else if (myage < 0 || myage > 130)
{
    MessageBox.Show("Enter valid age")
}
else 
{
    MessageBox.Show("Your age is " + myage.ToString())
}
