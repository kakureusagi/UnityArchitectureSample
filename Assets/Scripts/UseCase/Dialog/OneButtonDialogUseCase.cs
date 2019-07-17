namespace MvpSample {

	public class OneButtonDialogUseCsae : DialogUseCsaeBase {

		public string Title { get; }
		public string Body { get; }


		public OneButtonDialogUseCsae(string title, string body) {
			Title = title;
			Body = body;
		}

		public void OnCloseButton() {
			Close();
		}

	}

}