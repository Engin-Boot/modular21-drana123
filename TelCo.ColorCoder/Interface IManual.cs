
namespace TelCo.ColorCoder
{
    interface IManual
    {
        public void Printmanual();
    }

    class Manual
    {
      public Manual(IManual Manual)
        {
            Manual.Printmanual();
        }

    }
}
