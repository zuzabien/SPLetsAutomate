using Atata;

namespace SPLetsAutomate.PageObjects
{
    using _ = OutputPage;
    public class OutputPage : Page<_>
    {
        [FindByXPath("//div[@id='output']/div")]
        public Text<_> OutputTable { get; private set; }

        [FindById("name")]
        public Text<_> Name { get; private set; }

        [FindById("email")]
        public Text<_> Email { get; private set; }

        [FindById("currentAddress")]
        public Text<_> CurrentAddress { get; private set; }

        [FindById("permanentAddress")]
        public Text<_> PermanentAddress { get; private set; }
    }
}