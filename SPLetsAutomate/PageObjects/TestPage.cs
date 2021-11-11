using Atata;

namespace SPLetsAutomate.PageObjects
{
    using _ = TestPage;
    public class TestPage : Page<_>
    {
        [FindById("userName")]
        public TextInput<_> FullName { get; private set; }

        [FindById("userEmail")]
        public EmailInput<_> Email { get; private set; }

        [FindById("currentAddress")]
        public TextArea<_> CurrentAddress { get; private set; }

        [FindById("permanentAddress")]
        public TextArea<_> PermanentAddress { get; private set; }

        [FindById("submit"), Wait(5)]
        public Button<_> SubmitButton { get; private set; }

        public OutputPage SubmitForm()
        {
            ScrollDown().
            SubmitButton.Click();
            return Go.To<OutputPage>();
        }
    }
}