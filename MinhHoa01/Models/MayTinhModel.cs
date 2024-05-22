namespace MinhHoa01.Models
{
    public class MayTinhModel
    {
        public double So1 { set; get; }
        public double So2 { set; get; }

        public string PhepTinh { set; get; }

        public double KetQua()
        {
            double ketqua = 0;
            switch (PhepTinh)
            {
                case "+": ketqua = So1 + So2; break;
                case "-": ketqua = So1 - So2; break;
                case "*": ketqua = So1 * So2; break;
                case "/": ketqua = So1 / So2; break;
            }
            return ketqua;
        }

    }
}
