using System;
using UniRx;

namespace MvpSample {

	public class DialogUseCsaeBase {

		public IObservable<Unit> OnClose => onClose;
		private readonly Subject<Unit> onClose = new Subject<Unit>();
		


		protected void Close() {
			onClose.OnNext(Unit.Default);
		}
	}

}