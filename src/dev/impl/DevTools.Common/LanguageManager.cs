﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Globalization;
using Windows.ApplicationModel.Resources;
using Windows.Globalization;
using Windows.UI.Xaml;

namespace DevTools.Common
{
    public partial class LanguageManager : ObservableObject
    {
        private static LanguageManager _languageManager;

        private readonly Base64EncoderDecoderStrings _base64encoderdecoder = new Base64EncoderDecoderStrings();
        private readonly CommonStrings _common = new CommonStrings();
        private readonly HashGeneratorStrings _hashgenerator = new HashGeneratorStrings();
        private readonly JsonFormatterStrings _jsonformatter = new JsonFormatterStrings();
        private readonly MainPageStrings _mainpage = new MainPageStrings();
        private readonly RegExStrings _regex = new RegExStrings();
        private readonly SettingsStrings _settings = new SettingsStrings();
        private readonly TextDiffStrings _textdiff = new TextDiffStrings();

        /// <summary>
        /// Gets an instance of <see cref="LanguageManager"/>.
        /// </summary>
        public static LanguageManager Instance => _languageManager ?? (_languageManager = new LanguageManager());

        /// <summary>
        /// Gets if the text must be written from left to right or from right to left.
        /// </summary>
        public FlowDirection FlowDirection { get; private set; }

        /// <summary>
        /// Gets the <see cref="Base64EncoderDecoderStrings"/>.
        /// </summary>
        public Base64EncoderDecoderStrings Base64EncoderDecoder => _base64encoderdecoder;

        /// <summary>
        /// Gets the <see cref="CommonStrings"/>.
        /// </summary>
        public CommonStrings Common => _common;

        /// <summary>
        /// Gets the <see cref="HashGeneratorStrings"/>.
        /// </summary>
        public HashGeneratorStrings HashGenerator => _hashgenerator;

        /// <summary>
        /// Gets the <see cref="JsonFormatterStrings"/>.
        /// </summary>
        public JsonFormatterStrings JsonFormatter => _jsonformatter;

        /// <summary>
        /// Gets the <see cref="MainPageStrings"/>.
        /// </summary>
        public MainPageStrings MainPage => _mainpage;

        /// <summary>
        /// Gets the <see cref="RegExStrings"/>.
        /// </summary>
        public RegExStrings RegEx => _regex;

        /// <summary>
        /// Gets the <see cref="SettingsStrings"/>.
        /// </summary>
        public SettingsStrings Settings => _settings;

        /// <summary>
        /// Gets the <see cref="TextDiffStrings"/>.
        /// </summary>
        public TextDiffStrings TextDiff => _textdiff;

        /// <summary>
        /// Retrieves the current culture.
        /// </summary>
        public CultureInfo GetCurrentCulture()
        {
            return CultureInfo.CurrentUICulture;
        }

        /// <summary>
        /// Change the current culture of the application
        /// </summary>
        public void SetCurrentCulture(CultureInfo culture)
        {
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ApplicationLanguages.PrimaryLanguageOverride = culture.TextInfo.CultureName;

            if (culture.TextInfo.IsRightToLeft)
            {
                FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                FlowDirection = FlowDirection.LeftToRight;
            }

            // All the properties changed.
            OnPropertyChanged(new PropertyChangedEventArgs(string.Empty));
        }
    }

    public class Base64EncoderDecoderStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/Base64EncoderDecoder");

        /// <summary>
        /// Gets the resource ConfigurationTitle.
        /// </summary>
        public string ConfigurationTitle => _resources.GetString("ConfigurationTitle");

        /// <summary>
        /// Gets the resource ConversionDecode.
        /// </summary>
        public string ConversionDecode => _resources.GetString("ConversionDecode");

        /// <summary>
        /// Gets the resource ConversionDescription.
        /// </summary>
        public string ConversionDescription => _resources.GetString("ConversionDescription");

        /// <summary>
        /// Gets the resource ConversionEncode.
        /// </summary>
        public string ConversionEncode => _resources.GetString("ConversionEncode");

        /// <summary>
        /// Gets the resource ConversionTitle.
        /// </summary>
        public string ConversionTitle => _resources.GetString("ConversionTitle");

        /// <summary>
        /// Gets the resource DisplayName.
        /// </summary>
        public string DisplayName => _resources.GetString("DisplayName");

        /// <summary>
        /// Gets the resource EncodingDescription.
        /// </summary>
        public string EncodingDescription => _resources.GetString("EncodingDescription");

        /// <summary>
        /// Gets the resource EncodingTitle.
        /// </summary>
        public string EncodingTitle => _resources.GetString("EncodingTitle");

        /// <summary>
        /// Gets the resource InputTitle.
        /// </summary>
        public string InputTitle => _resources.GetString("InputTitle");

        /// <summary>
        /// Gets the resource OutputTitle.
        /// </summary>
        public string OutputTitle => _resources.GetString("OutputTitle");
    }

    public class CommonStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/Common");

        /// <summary>
        /// Gets the resource Clear.
        /// </summary>
        public string Clear => _resources.GetString("Clear");

        /// <summary>
        /// Gets the resource Copy.
        /// </summary>
        public string Copy => _resources.GetString("Copy");

        /// <summary>
        /// Gets the resource Cut.
        /// </summary>
        public string Cut => _resources.GetString("Cut");

        /// <summary>
        /// Gets the resource Delete.
        /// </summary>
        public string Delete => _resources.GetString("Delete");

        /// <summary>
        /// Gets the resource OpenFile.
        /// </summary>
        public string OpenFile => _resources.GetString("OpenFile");

        /// <summary>
        /// Gets the resource Paste.
        /// </summary>
        public string Paste => _resources.GetString("Paste");

        /// <summary>
        /// Gets the resource Redo.
        /// </summary>
        public string Redo => _resources.GetString("Redo");

        /// <summary>
        /// Gets the resource SelectAll.
        /// </summary>
        public string SelectAll => _resources.GetString("SelectAll");

        /// <summary>
        /// Gets the resource ToggleSwitchOff.
        /// </summary>
        public string ToggleSwitchOff => _resources.GetString("ToggleSwitchOff");

        /// <summary>
        /// Gets the resource ToggleSwitchOn.
        /// </summary>
        public string ToggleSwitchOn => _resources.GetString("ToggleSwitchOn");

        /// <summary>
        /// Gets the resource Undo.
        /// </summary>
        public string Undo => _resources.GetString("Undo");
    }

    public class HashGeneratorStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/HashGenerator");

        /// <summary>
        /// Gets the resource Configuration.
        /// </summary>
        public string Configuration => _resources.GetString("Configuration");

        /// <summary>
        /// Gets the resource DisplayName.
        /// </summary>
        public string DisplayName => _resources.GetString("DisplayName");

        /// <summary>
        /// Gets the resource Input.
        /// </summary>
        public string Input => _resources.GetString("Input");

        /// <summary>
        /// Gets the resource MD5.
        /// </summary>
        public string MD5 => _resources.GetString("MD5");

        /// <summary>
        /// Gets the resource SHA1.
        /// </summary>
        public string SHA1 => _resources.GetString("SHA1");

        /// <summary>
        /// Gets the resource SHA256.
        /// </summary>
        public string SHA256 => _resources.GetString("SHA256");

        /// <summary>
        /// Gets the resource SHA512.
        /// </summary>
        public string SHA512 => _resources.GetString("SHA512");

        /// <summary>
        /// Gets the resource Uppercase.
        /// </summary>
        public string Uppercase => _resources.GetString("Uppercase");
    }

    public class JsonFormatterStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/JsonFormatter");

        /// <summary>
        /// Gets the resource Configuration.
        /// </summary>
        public string Configuration => _resources.GetString("Configuration");

        /// <summary>
        /// Gets the resource DisplayName.
        /// </summary>
        public string DisplayName => _resources.GetString("DisplayName");
    }

    public class MainPageStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/MainPage");

        /// <summary>
        /// Gets the resource EnterCompactOverlayTooltip.
        /// </summary>
        public string EnterCompactOverlayTooltip => _resources.GetString("EnterCompactOverlayTooltip");

        /// <summary>
        /// Gets the resource ExitCompactOverlayTooltip.
        /// </summary>
        public string ExitCompactOverlayTooltip => _resources.GetString("ExitCompactOverlayTooltip");

        /// <summary>
        /// Gets the resource OpenInNewWindow.
        /// </summary>
        public string OpenInNewWindow => _resources.GetString("OpenInNewWindow");

        /// <summary>
        /// Gets the resource Search.
        /// </summary>
        public string Search => _resources.GetString("Search");

        /// <summary>
        /// Gets the resource WindowTitle.
        /// </summary>
        public string WindowTitle => _resources.GetString("WindowTitle");

        /// <summary>
        /// Gets the resource WindowTitleWithToolName.
        /// </summary>
        public string WindowTitleWithToolName => _resources.GetString("WindowTitleWithToolName");

        /// <summary>
        /// Gets the resource WindowTitleWithToolName with format.
        /// </summary>
        public string GetFormattedWindowTitleWithToolName(string param0)
        {
            return string.Format(WindowTitleWithToolName, param0);
        }
    }

    public class RegExStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/RegEx");

        /// <summary>
        /// Gets the resource DisplayName.
        /// </summary>
        public string DisplayName => _resources.GetString("DisplayName");
    }

    public class SettingsStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/Settings");

        /// <summary>
        /// Gets the resource About.
        /// </summary>
        public string About => _resources.GetString("About");

        /// <summary>
        /// Gets the resource AppTheme.
        /// </summary>
        public string AppTheme => _resources.GetString("AppTheme");

        /// <summary>
        /// Gets the resource AppThemeDescription.
        /// </summary>
        public string AppThemeDescription => _resources.GetString("AppThemeDescription");

        /// <summary>
        /// Gets the resource Behaviors.
        /// </summary>
        public string Behaviors => _resources.GetString("Behaviors");

        /// <summary>
        /// Gets the resource Dark.
        /// </summary>
        public string Dark => _resources.GetString("Dark");

        /// <summary>
        /// Gets the resource DisplayName.
        /// </summary>
        public string DisplayName => _resources.GetString("DisplayName");

        /// <summary>
        /// Gets the resource Font.
        /// </summary>
        public string Font => _resources.GetString("Font");

        /// <summary>
        /// Gets the resource HighlightCurrentLine.
        /// </summary>
        public string HighlightCurrentLine => _resources.GetString("HighlightCurrentLine");

        /// <summary>
        /// Gets the resource HighlightCurrentLineDescription.
        /// </summary>
        public string HighlightCurrentLineDescription => _resources.GetString("HighlightCurrentLineDescription");

        /// <summary>
        /// Gets the resource Light.
        /// </summary>
        public string Light => _resources.GetString("Light");

        /// <summary>
        /// Gets the resource LineNumbers.
        /// </summary>
        public string LineNumbers => _resources.GetString("LineNumbers");

        /// <summary>
        /// Gets the resource LineNumbersDescription.
        /// </summary>
        public string LineNumbersDescription => _resources.GetString("LineNumbersDescription");

        /// <summary>
        /// Gets the resource SmartDetection.
        /// </summary>
        public string SmartDetection => _resources.GetString("SmartDetection");

        /// <summary>
        /// Gets the resource SmartDetectionDescription.
        /// </summary>
        public string SmartDetectionDescription => _resources.GetString("SmartDetectionDescription");

        /// <summary>
        /// Gets the resource TextEditor.
        /// </summary>
        public string TextEditor => _resources.GetString("TextEditor");

        /// <summary>
        /// Gets the resource UsefulLinks.
        /// </summary>
        public string UsefulLinks => _resources.GetString("UsefulLinks");

        /// <summary>
        /// Gets the resource UseSystemSettings.
        /// </summary>
        public string UseSystemSettings => _resources.GetString("UseSystemSettings");

        /// <summary>
        /// Gets the resource WordWrap.
        /// </summary>
        public string WordWrap => _resources.GetString("WordWrap");
    }

    public class TextDiffStrings : ObservableObject
    {
        private readonly ResourceLoader _resources = ResourceLoader.GetForViewIndependentUse("DevTools.Common/TextDiff");

        /// <summary>
        /// Gets the resource Difference.
        /// </summary>
        public string Difference => _resources.GetString("Difference");

        /// <summary>
        /// Gets the resource DisplayName.
        /// </summary>
        public string DisplayName => _resources.GetString("DisplayName");

        /// <summary>
        /// Gets the resource LeftText.
        /// </summary>
        public string LeftText => _resources.GetString("LeftText");

        /// <summary>
        /// Gets the resource RightText.
        /// </summary>
        public string RightText => _resources.GetString("RightText");
    }
}