﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vocup.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vocup.Properties.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sie haben bereits alle Vokabeln mehrmals hintereinander richtig übersetzt.
        ///	
        ///Tipp: Unter Optionen können Sie festlegen, wie oft eine Vokabel richtig hintereinander übersetzt werden muss, damit sie als gelernt eingestuft wird..
        /// </summary>
        internal static string BookPracticeFinished {
            get {
                return ResourceManager.GetString("BookPracticeFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Herzlichen Glückwunsch!.
        /// </summary>
        internal static string BookPracticeFinishedT {
            get {
                return ResourceManager.GetString("BookPracticeFinishedT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beim Exportieren einer CSV Datei ist ein unerwarteter Fehler aufgetreten.
        ///Details:
        ///{0}.
        /// </summary>
        internal static string CsvExportError {
            get {
                return ResourceManager.GetString("CsvExportError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Möchten die Änderungen am Vokabelheft speichern, bevor Sie es in eine CSV-Datei exportieren? Sie können die Änderungen jederzeit auch später speichern. Exportiert wird immer die aktuelle Version inklusive ungespeicherter Änderungen..
        /// </summary>
        internal static string CsvExportSave {
            get {
                return ResourceManager.GetString("CsvExportSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jetzt speichern?.
        /// </summary>
        internal static string CsvExportSaveT {
            get {
                return ResourceManager.GetString("CsvExportSaveT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beim Importieren einer CSV Datei ist ein unerwarteter Fehler aufgetreten.
        ///Details:
        ///{0}.
        /// </summary>
        internal static string CsvImportError {
            get {
                return ResourceManager.GetString("CsvImportError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Der CSV Header konnte nicht gelesen werden.
        ///Bitte stellen Sie sicher, dass die Datei nicht leer ist..
        /// </summary>
        internal static string CsvInvalidHeader {
            get {
                return ResourceManager.GetString("CsvInvalidHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Der CSV Header verfügt über {0} Spalten, muss aber aus genau 2 Spalten bestehen.
        ///Stellen Sie sicher, dass die CSV Datei mit Excel im UTF-8 Format gespeichert wurde. Von älteren Vocup Versionen exportierte Dateien sind nicht kompatibel..
        /// </summary>
        internal static string CsvInvalidHeaderColumns {
            get {
                return ResourceManager.GetString("CsvInvalidHeaderColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehlerhafter CSV Header.
        /// </summary>
        internal static string CsvInvalidHeaderT {
            get {
                return ResourceManager.GetString("CsvInvalidHeaderT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Möchten Sie ein {0} - {1} Vokabelheft importieren, obwohl die Sprachen nicht mit Ihrem Vokabelheft übereinstimmen?
        ///Falls {0} und {1} keine Sprachen sondern Vokabeln sind, denken Sie bitte daran, in der ersten Zeile der CSV Datei links Ihre Muttersprache und rechts Ihre Fremdsprache einzutragen..
        /// </summary>
        internal static string CsvInvalidLanguages {
            get {
                return ResourceManager.GetString("CsvInvalidLanguages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Diese Vokabel ist in Ihrem Vokabelheft bereits vorhanden. Möchten Sie Ihre Eingabe verwerfen?.
        /// </summary>
        internal static string EditAddDuplicate {
            get {
                return ResourceManager.GetString("EditAddDuplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vokabel bereits vorhanden.
        /// </summary>
        internal static string EditDuplicateT {
            get {
                return ResourceManager.GetString("EditDuplicateT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die geänderte Vokabel befindet sich bereits in ihrem Vokabelheft. Möchten Sie diese Vokabel löschen?.
        /// </summary>
        internal static string EditToDuplicate {
            get {
                return ResourceManager.GetString("EditToDuplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Möchten Sie Ihre Änderungen und/oder Übungsergebnisse speichern?.
        /// </summary>
        internal static string GeneralSaveChanges {
            get {
                return ResourceManager.GetString("GeneralSaveChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Speichern?.
        /// </summary>
        internal static string GeneralSaveChangesT {
            get {
                return ResourceManager.GetString("GeneralSaveChangesT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ein Vokabelheft vom selben Pfad wurde bereits geladen. Möchten Sie das aktuelle Vokabelheft laden und die Daten überschreiben?.
        /// </summary>
        internal static string MergeOverride {
            get {
                return ResourceManager.GetString("MergeOverride", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Daten überschreiben?.
        /// </summary>
        internal static string MergeOverrideT {
            get {
                return ResourceManager.GetString("MergeOverrideT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Das aktuelle Vokabelheft konnte nicht im Explorer geöffnet werden. Bitte beachten Sie, dass dieses Feature mit manchen Betriebssystemen wie Linux oder Windows 10 S nicht kompatibel ist.
        ///Details: {0}.
        /// </summary>
        internal static string OpenInExplorerError {
            get {
                return ResourceManager.GetString("OpenInExplorerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehler beim Öffnen.
        /// </summary>
        internal static string OpenInExplorerErrorT {
            get {
                return ResourceManager.GetString("OpenInExplorerErrorT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Vokabelheftdatei {0} existiert nicht mehr..
        /// </summary>
        internal static string OpenInExplorerNotFound {
            get {
                return ResourceManager.GetString("OpenInExplorerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Datei nicht gefunden.
        /// </summary>
        internal static string OpenInExplorerNotFoundT {
            get {
                return ResourceManager.GetString("OpenInExplorerNotFoundT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Möchten die Änderungen am Vokabelheft speichern, bevor Sie es im Explorer öffnen? Sie können die Änderungen jederzeit auch später speichern..
        /// </summary>
        internal static string OpenInExplorerSave {
            get {
                return ResourceManager.GetString("OpenInExplorerSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jetzt speichern?.
        /// </summary>
        internal static string OpenInExplorerSaveT {
            get {
                return ResourceManager.GetString("OpenInExplorerSaveT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vocup kann die Datei {0} nicht öffnen, weil es sich weder um ein Vokabelheft, noch um eine Vocup-Datensicherung handelt..
        /// </summary>
        internal static string OpenUnknownFile {
            get {
                return ResourceManager.GetString("OpenUnknownFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unbekanntes Dateiformat.
        /// </summary>
        internal static string OpenUnknownFileT {
            get {
                return ResourceManager.GetString("OpenUnknownFileT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Für diese Sprache existieren bereits Sonderzeichen.
        /// </summary>
        internal static string SpecialCharAlreadyExists {
            get {
                return ResourceManager.GetString("SpecialCharAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beim Löschen der Sonderzeichendatei für {0} ist ein Fehler aufgetreten:
        ///{1}.
        /// </summary>
        internal static string SpecialCharDeleteError {
            get {
                return ResourceManager.GetString("SpecialCharDeleteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehler beim Löschen.
        /// </summary>
        internal static string SpecialCharDeleteErrorT {
            get {
                return ResourceManager.GetString("SpecialCharDeleteErrorT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Sonderzeichendatei {0} konnte nicht geladen werden. Überprüfen Sie die Datei unter {1} und löschen sie diese gegebenenfalls..
        /// </summary>
        internal static string SpecialCharInvalidFile {
            get {
                return ResourceManager.GetString("SpecialCharInvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehlerhafte Datei.
        /// </summary>
        internal static string SpecialCharInvalidFileT {
            get {
                return ResourceManager.GetString("SpecialCharInvalidFileT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beim Speichern der Sonderzeichendatei für {0} ist ein Fehler aufgetreten:
        ///{1}.
        /// </summary>
        internal static string SpecialCharSaveError {
            get {
                return ResourceManager.GetString("SpecialCharSaveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehler beim Speichern.
        /// </summary>
        internal static string SpecialCharSaveErrorT {
            get {
                return ResourceManager.GetString("SpecialCharSaveErrorT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unerwarteter Fehler.
        /// </summary>
        internal static string UnexpectedErrorT {
            get {
                return ResourceManager.GetString("UnexpectedErrorT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Vocup-Datensicherung ist fehlerhaft und konnte ich geöffnet werden:
        ///{0}.
        /// </summary>
        internal static string VdpInvalidFile {
            get {
                return ResourceManager.GetString("VdpInvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehlerhafte Datei.
        /// </summary>
        internal static string VdpInvalidFileT {
            get {
                return ResourceManager.GetString("VdpInvalidFileT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zusammenfassung
        /// -  {0} Datei(en) wiederhergestellt
        /// -  {1} Datei(en) übersprungen
        /// -  {2} Datei(en) fehlgeschlagen.
        /// </summary>
        internal static string VdpRestored {
            get {
                return ResourceManager.GetString("VdpRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wiederherstellung abgeschlossen.
        /// </summary>
        internal static string VdpRestoredT {
            get {
                return ResourceManager.GetString("VdpRestoredT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Vokabelheftdatei ist fehlerhaft und konnte nicht geöffnet werden..
        /// </summary>
        internal static string VhfInvalidFile {
            get {
                return ResourceManager.GetString("VhfInvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehlerhafte Vokabelheft-Datei.
        /// </summary>
        internal static string VhfInvalidFileT {
            get {
                return ResourceManager.GetString("VhfInvalidFileT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Mutter- und Fremdsprache der Vokabelheft-Datei konnten nicht gelesen werden oder sind identisch.
        ///Stellen Sie sicher, dass die Datei nicht leer ist..
        /// </summary>
        internal static string VhfInvalidLanguages {
            get {
                return ResourceManager.GetString("VhfInvalidLanguages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ein Eintrag dieser Vokabelheft-Datei ist ungültig. Die Datei kann deshalb nicht gelesen werden..
        /// </summary>
        internal static string VhfInvalidRow {
            get {
                return ResourceManager.GetString("VhfInvalidRow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Version der Vokabelheft-Datei konnte nicht gelesen werden.
        ///Bitte stellen Sie sicher, dass die Datei nicht leer ist..
        /// </summary>
        internal static string VhfInvalidVersion {
            get {
                return ResourceManager.GetString("VhfInvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Vokabelheft-Datei enthält keinen gültigen Verweis auf ihre Ergebnisdatei.
        ///Stellen Sie sicher, dass die Datei nicht leer ist..
        /// </summary>
        internal static string VhfInvalidVhrCode {
            get {
                return ResourceManager.GetString("VhfInvalidVhrCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Vokabelheft-Datei erfordert eine neuere Version von Vocup. Sie können entweder im Programm oder im Internet nach Updates suchen..
        /// </summary>
        internal static string VhfMustUpdate {
            get {
                return ResourceManager.GetString("VhfMustUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update erforderlich.
        /// </summary>
        internal static string VhfMustUpdateT {
            get {
                return ResourceManager.GetString("VhfMustUpdateT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Ergbnisdatei ist fehlerhaft und wird gelöscht. Die Übungsergebnisse gehen deshalb verloren..
        /// </summary>
        internal static string VhrInvalidFile {
            get {
                return ResourceManager.GetString("VhrInvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehlerhafte Ergebnis-Datei.
        /// </summary>
        internal static string VhrInvalidFileT {
            get {
                return ResourceManager.GetString("VhrInvalidFileT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die referenzierte Ergebnisdatei passt nicht zu diesem Vokabelheft. Die Ergebnisse werden gelöscht..
        /// </summary>
        internal static string VhrInvalidRowCount {
            get {
                return ResourceManager.GetString("VhrInvalidRowCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die referenzierte Ergebnisdatei wird von einem anderen Vokabelheft verwendet und passt nicht zu diesem. Daher werden keine Ergebnisse geladen..
        /// </summary>
        internal static string VhrInvalidRowCountAndOtherFile {
            get {
                return ResourceManager.GetString("VhrInvalidRowCountAndOtherFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eine Vokabelheft- oder Ergebnisdatei konnte nicht gespeichert werden..
        /// </summary>
        internal static string VocupFileWriteError {
            get {
                return ResourceManager.GetString("VocupFileWriteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eine Vokabelheft- oder Ergebnisdatei konnte nicht gespeichert werden:
        ///{0}.
        /// </summary>
        internal static string VocupFileWriteErrorEx {
            get {
                return ResourceManager.GetString("VocupFileWriteErrorEx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fehler beim Speichern.
        /// </summary>
        internal static string VocupFileWriteErrorT {
            get {
                return ResourceManager.GetString("VocupFileWriteErrorT", resourceCulture);
            }
        }
    }
}
