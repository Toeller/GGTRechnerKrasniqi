namespace OMG_Krasniqi_Olti
{
    public class Controller : IController
    {
        private IView view;
        private IModel model;

        public Controller(IModel model)
        {
            this.model = model;
        }

        public void setView(IView view)
        {
            this.view = view;
        }

        public int GgtBerechnen(int zahl1, int zahl2)
        {
            return model.Ggt(zahl1, zahl2);
        }
    }
}
