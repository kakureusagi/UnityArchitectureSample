namespace MvpSample {

	public interface IDialogFactory {

		void Create<TModel>(TModel model) where TModel : DialogModelBase;

	}

}