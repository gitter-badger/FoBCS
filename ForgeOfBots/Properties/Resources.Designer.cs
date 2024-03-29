﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForgeOfBots.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ForgeOfBots.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die let res = await fetch(&quot;https://##WorldID##.forgeofempires.com/game/json?h=##UserKey##&quot;, {
        ///    &quot;credentials&quot;: &quot;include&quot;,
        ///    &quot;headers&quot;: {
        ///        &quot;accept&quot;: &quot;*/*&quot;,
        ///        &quot;accept-language&quot;: &quot;en-US,en;q=0.9,de-DE;q=0.8,de;q=0.7&quot;,
        ///        &quot;cache-control&quot;: &quot;no-cache&quot;,
        ///        &quot;client-identification&quot;: &quot;version=##Version##; requiredVersion=##Version##; platform=bro; platformType=html5; platformVersion=web&quot;,
        ///        &quot;content-type&quot;: &quot;application/json&quot;,
        ///        &quot;pragma&quot;: &quot;no-cache&quot;,
        ///        &quot;sec-fetch-mode&quot; [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        public static string fetchData {
            get {
                return ResourceManager.GetString("fetchData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die let res = await fetch(##url##, {
        ///    &quot;credentials&quot;: &quot;include&quot;,
        ///    &quot;headers&quot;: {
        ///        &quot;accept&quot;: &quot;*/*&quot;,
        ///        &quot;accept-language&quot;: &quot;en-US,en;q=0.9,de-DE;q=0.8,de;q=0.7&quot;,
        ///        &quot;cache-control&quot;: &quot;no-cache&quot;,
        ///        &quot;content-type&quot;: &quot;application/json&quot;,
        ///        &quot;pragma&quot;: &quot;no-cache&quot;,
        ///        &quot;sec-fetch-mode&quot;: &quot;cors&quot;,
        ///        &quot;sec-fetch-site&quot;: &quot;same-origin&quot;,
        ///        &quot;user-agent&quot;: &quot;Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36&quot;
        ///     [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        public static string fetchMetaData {
            get {
                return ResourceManager.GetString("fetchMetaData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die if (document.readyState == &quot;complete&quot;) FoELogin();
        ///else {
        ///    document.addEventListener(&quot;DOMContentLoaded&quot;, () =&gt; {
        ///        FoELogin();
        ///    });
        ///}
        ///
        ///async function FoELogin() {
        ///    console.log(window.location.href);
        ///    if (window.location.href.indexOf(&quot;de0&quot;) &lt;= 0) {
        ///        await FoETimer(1000);
        ///        console.log(1);
        ///        fetch(&quot;https://de.forgeofempires.com/glps/login_check&quot;, {
        ///            &quot;credentials&quot;: &quot;include&quot;,
        ///            &quot;headers&quot;: {
        ///                &quot;User-Agent&quot;: &quot;Mozilla/5.0 (Wind [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        public static string preloadLoginWorld {
            get {
                return ResourceManager.GetString("preloadLoginWorld", resourceCulture);
            }
        }
    }
}
