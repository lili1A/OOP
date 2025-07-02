int[] values = { 1, 3, 5, 7, 9 }; // looping through this array 
int total = 0;

for (int i = 0; i < values.Length; i++) // loop through indexes 
{
    if (i % 2 == 0)
    {
        total += values[i];
    }
    else
    {
        total -= values[i];
    }
}
MessageBox.Show(total.ToString());

// output 
// 1st 0: value: 1, i is even, total = 0+1 = 1
// 2nd 1: value: 3, i is odd, total = 1-3 = -2
// 3rd 2: value: 5, i is even, total = -2+5 = 3
// 4th 3: value: 7, i is odd, total = 3-7 =-4
// 5th 4: value: 9, i is even, total = -4+9 = 5

// 5
