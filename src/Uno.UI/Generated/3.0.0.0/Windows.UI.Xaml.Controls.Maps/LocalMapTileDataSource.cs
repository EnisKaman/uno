#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LocalMapTileDataSource : global::Windows.UI.Xaml.Controls.Maps.MapTileDataSource
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string UriFormatString
		{
			get
			{
				throw new global::System.NotImplementedException("The member string LocalMapTileDataSource.UriFormatString is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20LocalMapTileDataSource.UriFormatString");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource", "string LocalMapTileDataSource.UriFormatString");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public LocalMapTileDataSource() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource", "LocalMapTileDataSource.LocalMapTileDataSource()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource.LocalMapTileDataSource()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public LocalMapTileDataSource( string uriFormatString) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource", "LocalMapTileDataSource.LocalMapTileDataSource(string uriFormatString)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource.LocalMapTileDataSource(string)
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource.UriFormatString.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource.UriFormatString.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource.UriRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource.UriRequested.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource, global::Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs> UriRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource", "event TypedEventHandler<LocalMapTileDataSource, MapTileUriRequestedEventArgs> LocalMapTileDataSource.UriRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource", "event TypedEventHandler<LocalMapTileDataSource, MapTileUriRequestedEventArgs> LocalMapTileDataSource.UriRequested");
			}
		}
		#endif
	}
}
