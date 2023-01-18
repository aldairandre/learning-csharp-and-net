/*
  Break and Continue in While Loop
    You can also use break and continue in while loops:
*/
int i = 0;
while (i < 10) 
{
  if (i == 4) 
  {
    i++;
    continue;
  }
  Console.WriteLine(i);
  i++;
}