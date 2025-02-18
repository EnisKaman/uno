#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StoreRateAndReviewResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreRateAndReviewResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreRateAndReviewResult.ExtendedError");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ExtendedJsonData
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StoreRateAndReviewResult.ExtendedJsonData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StoreRateAndReviewResult.ExtendedJsonData");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Services.Store.StoreRateAndReviewStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreRateAndReviewStatus StoreRateAndReviewResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreRateAndReviewStatus%20StoreRateAndReviewResult.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool WasUpdated
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StoreRateAndReviewResult.WasUpdated is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20StoreRateAndReviewResult.WasUpdated");
			}
		}
		#endif
		// Forced skipping of method Windows.Services.Store.StoreRateAndReviewResult.ExtendedError.get
		// Forced skipping of method Windows.Services.Store.StoreRateAndReviewResult.ExtendedJsonData.get
		// Forced skipping of method Windows.Services.Store.StoreRateAndReviewResult.WasUpdated.get
		// Forced skipping of method Windows.Services.Store.StoreRateAndReviewResult.Status.get
	}
}
