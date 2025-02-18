#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarPenButton : global::Windows.UI.Xaml.Controls.InkToolbarToolButton
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double SelectedStrokeWidth
		{
			get
			{
				return (double)this.GetValue(SelectedStrokeWidthProperty);
			}
			set
			{
				this.SetValue(SelectedStrokeWidthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int SelectedBrushIndex
		{
			get
			{
				return (int)this.GetValue(SelectedBrushIndexProperty);
			}
			set
			{
				this.SetValue(SelectedBrushIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.Brush> Palette
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.Brush>)this.GetValue(PaletteProperty);
			}
			set
			{
				this.SetValue(PaletteProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double MinStrokeWidth
		{
			get
			{
				return (double)this.GetValue(MinStrokeWidthProperty);
			}
			set
			{
				this.SetValue(MinStrokeWidthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double MaxStrokeWidth
		{
			get
			{
				return (double)this.GetValue(MaxStrokeWidthProperty);
			}
			set
			{
				this.SetValue(MaxStrokeWidthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Brush SelectedBrush
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(SelectedBrushProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MaxStrokeWidthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MaxStrokeWidth), typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MinStrokeWidthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MinStrokeWidth), typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PaletteProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Palette), typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.Brush>), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.Brush>)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedBrushIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedBrushIndex), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedBrushProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedBrush), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty SelectedStrokeWidthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(SelectedStrokeWidth), typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.Palette.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.Palette.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.MinStrokeWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.MinStrokeWidth.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidth.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrush.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedStrokeWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedStrokeWidth.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.PaletteProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.MinStrokeWidthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedStrokeWidthProperty.get
	}
}
