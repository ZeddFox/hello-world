namespace GitHub_Hello_World
{
    class MyProgram
    {
        ASCII_Letters textDraw;

        public void Run(bool keepRunning)
        {
            textDraw = new ASCII_Letters();

            textDraw.WriteOutArrayOfStrings('H', 0, 0);
            textDraw.WriteOutArrayOfStrings('E', 6, 0);
            textDraw.WriteOutArrayOfStrings('L', 12, 0);
            textDraw.WriteOutArrayOfStrings('L', 18, 0);
            textDraw.WriteOutArrayOfStrings('O', 24, 0);

            textDraw.WriteOutArrayOfStrings('W', 32, 0);
            textDraw.WriteOutArrayOfStrings('O', 38, 0);
            textDraw.WriteOutArrayOfStrings('R', 44, 0);
            textDraw.WriteOutArrayOfStrings('L', 50, 0);
            textDraw.WriteOutArrayOfStrings('D', 56, 0);
            textDraw.WriteOutArrayOfStrings('!', 62, 0);
        }
    }
}
