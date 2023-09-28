using Lab10Rez.Devices;
namespace Lab10Rez.Interfaces
{
    interface IContactFullpayment : IPoSPayment
    {
        public void IntroduCardul();
        public void ExtrageCardul();
    }
}
