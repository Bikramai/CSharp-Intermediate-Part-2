using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiers
{
    public class GoldCustomer : Customer1
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customer1();
        }
    }
}