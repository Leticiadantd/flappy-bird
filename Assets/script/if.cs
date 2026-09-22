public void Update()
{
    if (ligado == true)
    {
        if (timer < 10)
        {
            timer += 0.0001f;

        }   else
        {
            timer = 0;
        }
    }


}