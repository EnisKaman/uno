#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.DataTransfer
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataTransferManager 
	{
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataTransferManager.DataRequested.add
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataTransferManager.DataRequested.remove
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataTransferManager.TargetApplicationChosen.add
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataTransferManager.TargetApplicationChosen.remove
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataTransferManager.ShareProvidersRequested.add
		// Forced skipping of method Windows.ApplicationModel.DataTransfer.DataTransferManager.ShareProvidersRequested.remove
		#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public static void ShowShareUI( global::Windows.ApplicationModel.DataTransfer.ShareUIOptions options)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "void DataTransferManager.ShowShareUI(ShareUIOptions options)");
		}
		#endif
		// Skipping already declared method Windows.ApplicationModel.DataTransfer.DataTransferManager.IsSupported()
		#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public static void ShowShareUI()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "void DataTransferManager.ShowShareUI()");
		}
		#endif
		// Skipping already declared method Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView()
		#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.DataTransfer.DataTransferManager, global::Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs> DataRequested
		{
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataTransferManager.DataRequested");
			}
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataTransferManager.DataRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.DataTransfer.DataTransferManager, global::Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs> TargetApplicationChosen
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> DataTransferManager.TargetApplicationChosen");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> DataTransferManager.TargetApplicationChosen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.DataTransfer.DataTransferManager, global::Windows.ApplicationModel.DataTransfer.ShareProvidersRequestedEventArgs> ShareProvidersRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "event TypedEventHandler<DataTransferManager, ShareProvidersRequestedEventArgs> DataTransferManager.ShareProvidersRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.DataTransfer.DataTransferManager", "event TypedEventHandler<DataTransferManager, ShareProvidersRequestedEventArgs> DataTransferManager.ShareProvidersRequested");
			}
		}
		#endif
	}
}
