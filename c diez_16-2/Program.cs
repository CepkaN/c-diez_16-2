namespace c_diez_16_2
{
    using c_dies_16_lib;

    internal class Program
    {
        static void Main(string[] args)
        {
            Plug1 Pl1 = new Plug1("aaa", "2.0");
            Plug2 Pl2 = new Plug2("bbb", "1.6");
            Plug3 Pl3 = new Plug3("ccc", "3.7");
            Plug4 Pl4 = new Plug4("ddd", "6.7");
            Plugins PPP = new Plugins();
            PPP.Add(Pl1);
            PPP.Add(Pl2);
            PPP.Add(Pl3);
            PPP.Add(Pl4);
            PPP.RuRun(24, 12);
            PPP.Mos();
            foreach(var R in PPP.GetPluginNames)
            {
                R.Mostra();
            }
        }
    }
}