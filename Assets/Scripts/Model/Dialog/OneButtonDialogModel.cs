namespace MvpSample {

	public class OneButtonDialogModel : DialogModelBase {

		public string Title { get; }
		public string Body { get; }


		public OneButtonDialogModel(string title, string body) {
			Title = title;
			Body = body;
		}

		public void OnCloseButton() {
			Close();
		}

	}

}