/*
  Break and Continue in While Loop
    You can also use break and continue in while loops:
*/
int i = 0;
while (i < 10) 
{
  Console.WriteLine(i);
  i++;
  if (i == 4) 
  {
    break;
  }
}