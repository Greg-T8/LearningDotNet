
#region First exercise - Loops and Overflow

int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}

#endregion


#endif

#region Second exercise - Checked and unchecked

try
{
    checked
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
}
catch (OverflowException)
{
    WriteLine("The loop has overflowed.");
}


#endregion