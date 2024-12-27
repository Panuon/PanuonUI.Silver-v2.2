using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class Timeline
        : ItemsControl
    {
        #region Ctor
        static Timeline()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Timeline), new FrameworkPropertyMetadata(typeof(Timeline)));
        }
        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey ToggleDataTemplateKey { get; } =
          new ComponentResourceKey(typeof(Timeline), nameof(ToggleDataTemplateKey));

        public static ComponentResourceKey PendingToggleDataTemplateKey { get; } =
          new ComponentResourceKey(typeof(Timeline), nameof(PendingToggleDataTemplateKey));

        public static ComponentResourceKey CompletedGlyphTemplateKey { get; } =
          new ComponentResourceKey(typeof(Timeline), nameof(CompletedGlyphTemplateKey));
        #endregion

        #region Properties

        #region EmptyContent
        public object EmptyContent
        {
            get { return (object)GetValue(EmptyContentProperty); }
            set { SetValue(EmptyContentProperty, value); }
        }

        public static readonly DependencyProperty EmptyContentProperty =
            DependencyProperty.Register("EmptyContent", typeof(object), typeof(Timeline));
        #endregion

        #region Scrollable
        public bool Scrollable
        {
            get { return (bool)GetValue(ScrollableProperty); }
            set { SetValue(ScrollableProperty, value); }
        }

        public static readonly DependencyProperty ScrollableProperty =
            DependencyProperty.Register("Scrollable", typeof(bool), typeof(Timeline));
        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(Timeline), new PropertyMetadata(Orientation.Vertical));
        #endregion

        #region ShowIndex
        public bool ShowIndex
        {
            get { return (bool)GetValue(ShowIndexProperty); }
            set { SetValue(ShowIndexProperty, value); }
        }

        public static readonly DependencyProperty ShowIndexProperty =
            DependencyProperty.Register("ShowIndex", typeof(bool), typeof(Timeline));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(Timeline));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(Timeline));
        #endregion

        #region Items Properties

        #region ItemsWidth
        public double ItemsWidth
        {
            get { return (double)GetValue(ItemsWidthProperty); }
            set { SetValue(ItemsWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.Register("ItemsWidth", typeof(double), typeof(Timeline), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public double ItemsHeight
        {
            get { return (double)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(double), typeof(Timeline), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsMinWidth
        public double ItemsMinWidth
        {
            get { return (double)GetValue(ItemsMinWidthProperty); }
            set { SetValue(ItemsMinWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsMinWidthProperty =
            DependencyProperty.Register("ItemsMinWidth", typeof(double), typeof(Timeline), new PropertyMetadata(0d));
        #endregion

        #region ItemsMinHeight
        public double ItemsMinHeight
        {
            get { return (double)GetValue(ItemsMinHeightProperty); }
            set { SetValue(ItemsMinHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsMinHeightProperty =
            DependencyProperty.Register("ItemsMinHeight", typeof(double), typeof(Timeline), new PropertyMetadata(0d));
        #endregion

        #region ItemsMaxWidth
        public double ItemsMaxWidth
        {
            get { return (double)GetValue(ItemsMaxWidthProperty); }
            set { SetValue(ItemsMaxWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsMaxWidthProperty =
            DependencyProperty.Register("ItemsMaxWidth", typeof(double), typeof(Timeline), new PropertyMetadata(double.MaxValue));
        #endregion

        #region ItemsMaxHeight
        public double ItemsMaxHeight
        {
            get { return (double)GetValue(ItemsMaxHeightProperty); }
            set { SetValue(ItemsMaxHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsMaxHeightProperty =
            DependencyProperty.Register("ItemsMaxHeight", typeof(double), typeof(Timeline), new PropertyMetadata(double.MaxValue));
        #endregion

        #region ItemsToggleTemplate
        public DataTemplate ItemsToggleTemplate
        {
            get { return (DataTemplate)GetValue(ItemsToggleTemplateProperty); }
            set { SetValue(ItemsToggleTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemsToggleTemplateProperty =
            DependencyProperty.Register("ItemsToggleTemplate", typeof(DataTemplate), typeof(Timeline));
        #endregion

        #region ItemsToggleStroke
        public Brush ItemsToggleStroke
        {
            get { return (Brush)GetValue(ItemsToggleStrokeProperty); }
            set { SetValue(ItemsToggleStrokeProperty, value); }
        }

        public static readonly DependencyProperty ItemsToggleStrokeProperty =
            DependencyProperty.Register("ItemsToggleStroke", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsToggleFill
        public Brush ItemsToggleFill
        {
            get { return (Brush)GetValue(ItemsToggleFillProperty); }
            set { SetValue(ItemsToggleFillProperty, value); }
        }

        public static readonly DependencyProperty ItemsToggleFillProperty =
            DependencyProperty.Register("ItemsToggleFill", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsToggleStrokeThickness
        public double ItemsToggleStrokeThickness
        {
            get { return (double)GetValue(ItemsToggleStrokeThicknessProperty); }
            set { SetValue(ItemsToggleStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsToggleStrokeThicknessProperty =
            DependencyProperty.Register("ItemsToggleStrokeThickness", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsToggleSize
        public double ItemsToggleSize
        {
            get { return (double)GetValue(ItemsToggleSizeProperty); }
            set { SetValue(ItemsToggleSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemsToggleSizeProperty =
            DependencyProperty.Register("ItemsToggleSize", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsPendingToggleTemplate
        public DataTemplate ItemsPendingToggleTemplate
        {
            get { return (DataTemplate)GetValue(ItemsPendingToggleTemplateProperty); }
            set { SetValue(ItemsPendingToggleTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemsPendingToggleTemplateProperty =
            DependencyProperty.Register("ItemsPendingToggleTemplate", typeof(DataTemplate), typeof(Timeline));
        #endregion

        #region ItemsPendingSpinGlyphBrush
        public Brush ItemsPendingSpinGlyphBrush
        {
            get { return (Brush)GetValue(ItemsPendingSpinGlyphBrushProperty); }
            set { SetValue(ItemsPendingSpinGlyphBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsPendingSpinGlyphBrushProperty =
            DependencyProperty.Register("ItemsPendingSpinGlyphBrush", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsPendingSpinGlyphThickness
        public double ItemsPendingSpinGlyphThickness
        {
            get { return (double)GetValue(ItemsPendingSpinGlyphThicknessProperty); }
            set { SetValue(ItemsPendingSpinGlyphThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsPendingSpinGlyphThicknessProperty =
            DependencyProperty.Register("ItemsPendingSpinGlyphThickness", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsStickThickness
        public double ItemsStickThickness
        {
            get { return (double)GetValue(ItemsStickThicknessProperty); }
            set { SetValue(ItemsStickThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsStickThicknessProperty =
            DependencyProperty.Register("ItemsStickThickness", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsStickStroke
        public Brush ItemsStickStroke
        {
            get { return (Brush)GetValue(ItemsStickStrokeProperty); }
            set { SetValue(ItemsStickStrokeProperty, value); }
        }

        public static readonly DependencyProperty ItemsStickStrokeProperty =
            DependencyProperty.Register("ItemsStickStroke", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsStickStrokeThickness
        public double ItemsStickStrokeThickness
        {
            get { return (double)GetValue(ItemsStickStrokeThicknessProperty); }
            set { SetValue(ItemsStickStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsStickStrokeThicknessProperty =
            DependencyProperty.Register("ItemsStickStrokeThickness", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsStickFill
        public Brush ItemsStickFill
        {
            get { return (Brush)GetValue(ItemsStickFillProperty); }
            set { SetValue(ItemsStickFillProperty, value); }
        }

        public static readonly DependencyProperty ItemsStickFillProperty =
            DependencyProperty.Register("ItemsStickFill", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsCompletedToggleStroke
        public Brush ItemsCompletedToggleStroke
        {
            get { return (Brush)GetValue(ItemsCompletedToggleStrokeProperty); }
            set { SetValue(ItemsCompletedToggleStrokeProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedToggleStrokeProperty =
            DependencyProperty.Register("ItemsCompletedToggleStroke", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsCompletedToggleFill
        public Brush ItemsCompletedToggleFill
        {
            get { return (Brush)GetValue(ItemsCompletedToggleFillProperty); }
            set { SetValue(ItemsCompletedToggleFillProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedToggleFillProperty =
            DependencyProperty.Register("ItemsCompletedToggleFill", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsCompletedToggleStrokeThickness
        public double ItemsCompletedToggleStrokeThickness
        {
            get { return (double)GetValue(ItemsCompletedToggleStrokeThicknessProperty); }
            set { SetValue(ItemsCompletedToggleStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedToggleStrokeThicknessProperty =
            DependencyProperty.Register("ItemsCompletedToggleStrokeThickness", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsCompletedGlyphTemplate
        public DataTemplate ItemsCompletedGlyphTemplate
        {
            get { return (DataTemplate)GetValue(ItemsCompletedGlyphTemplateProperty); }
            set { SetValue(ItemsCompletedGlyphTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedGlyphTemplateProperty =
            DependencyProperty.Register("ItemsCompletedGlyphTemplate", typeof(DataTemplate), typeof(Timeline));
        #endregion

        #region ItemsCompletedGlyphBrush
        public Brush ItemsCompletedGlyphBrush
        {
            get { return (Brush)GetValue(ItemsCompletedGlyphBrushProperty); }
            set { SetValue(ItemsCompletedGlyphBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedGlyphBrushProperty =
            DependencyProperty.Register("ItemsCompletedGlyphBrush", typeof(Brush), typeof(Timeline), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsCompletedStickStroke
        public Brush ItemsCompletedStickStroke
        {
            get { return (Brush)GetValue(ItemsCompletedStickStrokeProperty); }
            set { SetValue(ItemsCompletedStickStrokeProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedStickStrokeProperty =
            DependencyProperty.Register("ItemsCompletedStickStroke", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsCompletedStickStrokeThickness
        public double ItemsCompletedStickStrokeThickness
        {
            get { return (double)GetValue(ItemsCompletedStickStrokeThicknessProperty); }
            set { SetValue(ItemsCompletedStickStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedStickStrokeThicknessProperty =
            DependencyProperty.Register("ItemsCompletedStickStrokeThickness", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsCompletedStickFill
        public Brush ItemsCompletedStickFill
        {
            get { return (Brush)GetValue(ItemsCompletedStickFillProperty); }
            set { SetValue(ItemsCompletedStickFillProperty, value); }
        }

        public static readonly DependencyProperty ItemsCompletedStickFillProperty =
            DependencyProperty.Register("ItemsCompletedStickFill", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(Timeline));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(Timeline));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(Timeline), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(Timeline), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsHeaderVerticalContentAlignment
        public VerticalAlignment ItemsHeaderVerticalContentAlignment
        {
            get { return (VerticalAlignment)GetValue(ItemsHeaderVerticalContentAlignmentProperty); }
            set { SetValue(ItemsHeaderVerticalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderVerticalContentAlignmentProperty =
            DependencyProperty.Register("ItemsHeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(Timeline));
        #endregion

        #region ItemsHeaderHorizontalContentAlignment
        public HorizontalAlignment ItemsHeaderHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(ItemsHeaderHorizontalContentAlignmentProperty); }
            set { SetValue(ItemsHeaderHorizontalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderHorizontalContentAlignmentProperty =
            DependencyProperty.Register("ItemsHeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(Timeline));
        #endregion

        #region ItemsHeaderPadding
        public Thickness ItemsHeaderPadding
        {
            get { return (Thickness)GetValue(ItemsHeaderPaddingProperty); }
            set { SetValue(ItemsHeaderPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderPaddingProperty =
            DependencyProperty.Register("ItemsHeaderPadding", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsHeaderFontSize
        public double ItemsHeaderFontSize
        {
            get { return (double)GetValue(ItemsHeaderFontSizeProperty); }
            set { SetValue(ItemsHeaderFontSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderFontSizeProperty =
            DependencyProperty.Register("ItemsHeaderFontSize", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsHeaderFontWeight
        public FontWeight ItemsHeaderFontWeight
        {
            get { return (FontWeight)GetValue(ItemsHeaderFontWeightProperty); }
            set { SetValue(ItemsHeaderFontWeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderFontWeightProperty =
            DependencyProperty.Register("ItemsHeaderFontWeight", typeof(FontWeight), typeof(Timeline));
        #endregion

        #region ItemsHeaderForeground
        public Brush ItemsHeaderForeground
        {
            get { return (Brush)GetValue(ItemsHeaderForegroundProperty); }
            set { SetValue(ItemsHeaderForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderForegroundProperty =
            DependencyProperty.Register("ItemsHeaderForeground", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsHeaderBackground
        public Brush ItemsHeaderBackground
        {
            get { return (Brush)GetValue(ItemsHeaderBackgroundProperty); }
            set { SetValue(ItemsHeaderBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderBackgroundProperty =
            DependencyProperty.Register("ItemsHeaderBackground", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsHeaderBorderBrush
        public Brush ItemsHeaderBorderBrush
        {
            get { return (Brush)GetValue(ItemsHeaderBorderBrushProperty); }
            set { SetValue(ItemsHeaderBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderBorderBrushProperty =
            DependencyProperty.Register("ItemsHeaderBorderBrush", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsHeaderBorderThickness
        public Thickness ItemsHeaderBorderThickness
        {
            get { return (Thickness)GetValue(ItemsHeaderBorderThicknessProperty); }
            set { SetValue(ItemsHeaderBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderBorderThicknessProperty =
            DependencyProperty.Register("ItemsHeaderBorderThickness", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsHeaderCornerRadius
        public CornerRadius ItemsHeaderCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsHeaderCornerRadiusProperty); }
            set { SetValue(ItemsHeaderCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderCornerRadiusProperty =
            DependencyProperty.Register("ItemsHeaderCornerRadius", typeof(CornerRadius), typeof(Timeline));
        #endregion

        #region ItemsHeaderShadowColor
        public Color? ItemsHeaderShadowColor
        {
            get { return (Color?)GetValue(ItemsHeaderShadowColorProperty); }
            set { SetValue(ItemsHeaderShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderShadowColorProperty =
            DependencyProperty.Register("ItemsHeaderShadowColor", typeof(Color?), typeof(Timeline));
        #endregion

        #region ItemsHeaderHeight
        public double ItemsHeaderHeight
        {
            get { return (double)GetValue(ItemsHeaderHeightProperty); }
            set { SetValue(ItemsHeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderHeightProperty =
            DependencyProperty.Register("ItemsHeaderHeight", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsHeaderPlacement
        public HeaderPlacement ItemsHeaderPlacement
        {
            get { return (HeaderPlacement)GetValue(ItemsHeaderPlacementProperty); }
            set { SetValue(ItemsHeaderPlacementProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderPlacementProperty =
            DependencyProperty.Register("ItemsHeaderPlacement", typeof(HeaderPlacement), typeof(Timeline));
        #endregion

        #region ItemsSeparatorVisibility
        public Visibility ItemsSeparatorVisibility
        {
            get { return (Visibility)GetValue(ItemsSeparatorVisibilityProperty); }
            set { SetValue(ItemsSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.Register("ItemsSeparatorVisibility", typeof(Visibility), typeof(Timeline), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #region ItemsSeparatorBrush
        public Brush ItemsSeparatorBrush
        {
            get { return (Brush)GetValue(ItemsSeparatorBrushProperty); }
            set { SetValue(ItemsSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.Register("ItemsSeparatorBrush", typeof(Brush), typeof(Timeline), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsSeparatorThickness
        public double ItemsSeparatorThickness
        {
            get { return (double)GetValue(ItemsSeparatorThicknessProperty); }
            set { SetValue(ItemsSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.Register("ItemsSeparatorThickness", typeof(double), typeof(Timeline), new PropertyMetadata(1d));
        #endregion

        #region ItemsSeparatorMargin
        public Thickness ItemsSeparatorMargin
        {
            get { return (Thickness)GetValue(ItemsSeparatorMarginProperty); }
            set { SetValue(ItemsSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.Register("ItemsSeparatorMargin", typeof(Thickness), typeof(Timeline));
        #endregion

        #endregion

        #endregion

        #region Overrides
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TimelineItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TimelineItem();
        }
        #endregion

        #region Methods
        #endregion
    }
}
