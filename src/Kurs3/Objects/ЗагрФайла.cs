﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kurs3
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Загр файла.
    /// </summary>
    // *** Start programmer edit section *** (ЗагрФайла CustomAttributes)

    // *** End programmer edit section *** (ЗагрФайла CustomAttributes)
    [AutoAltered()]
    [Caption("Загрузка файла")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗагрФайлаE", new string[] {
            "Дата as \'Дата\'",
            "Путь as \'Путь\'"})]
    [AssociatedDetailViewAttribute("ЗагрФайлаE", "ТчЗагр", "ТчЗагрE", true, "", "Атрибуты загруженного файла", true, new string[] {
            ""})]
    [View("ЗагрФайлаL", new string[] {
            "Дата as \'Дата\'",
            "Путь as \'Путь\'"})]
    public class ЗагрФайла : ICSSoft.STORMNET.DataObject
    {
        
        private string fПуть;
        
        private System.DateTime fДата;
        
        private IIS.Kurs3.ЭксФайлы fЭксФайлы;
        
        private IIS.Kurs3.DetailArrayOfТчЗагр fТчЗагр;
        
        // *** Start programmer edit section *** (ЗагрФайла CustomMembers)

        // *** End programmer edit section *** (ЗагрФайла CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрФайла.Дата CustomAttributes)

        // *** End programmer edit section *** (ЗагрФайла.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрФайла.Дата Get start)

                // *** End programmer edit section *** (ЗагрФайла.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ЗагрФайла.Дата Get end)

                // *** End programmer edit section *** (ЗагрФайла.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрФайла.Дата Set start)

                // *** End programmer edit section *** (ЗагрФайла.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ЗагрФайла.Дата Set end)

                // *** End programmer edit section *** (ЗагрФайла.Дата Set end)
            }
        }
        
        /// <summary>
        /// Путь.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрФайла.Путь CustomAttributes)

        // *** End programmer edit section *** (ЗагрФайла.Путь CustomAttributes)
        [StrLen(255)]
        public virtual string Путь
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрФайла.Путь Get start)

                // *** End programmer edit section *** (ЗагрФайла.Путь Get start)
                string result = this.fПуть;
                // *** Start programmer edit section *** (ЗагрФайла.Путь Get end)

                // *** End programmer edit section *** (ЗагрФайла.Путь Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрФайла.Путь Set start)

                // *** End programmer edit section *** (ЗагрФайла.Путь Set start)
                this.fПуть = value;
                // *** Start programmer edit section *** (ЗагрФайла.Путь Set end)

                // *** End programmer edit section *** (ЗагрФайла.Путь Set end)
            }
        }
        
        /// <summary>
        /// Загр файла.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрФайла.ЭксФайлы CustomAttributes)

        // *** End programmer edit section *** (ЗагрФайла.ЭксФайлы CustomAttributes)
        [PropertyStorage(new string[] {
                "ЭксФайлы"})]
        [NotNull()]
        public virtual IIS.Kurs3.ЭксФайлы ЭксФайлы
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрФайла.ЭксФайлы Get start)

                // *** End programmer edit section *** (ЗагрФайла.ЭксФайлы Get start)
                IIS.Kurs3.ЭксФайлы result = this.fЭксФайлы;
                // *** Start programmer edit section *** (ЗагрФайла.ЭксФайлы Get end)

                // *** End programmer edit section *** (ЗагрФайла.ЭксФайлы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрФайла.ЭксФайлы Set start)

                // *** End programmer edit section *** (ЗагрФайла.ЭксФайлы Set start)
                this.fЭксФайлы = value;
                // *** Start programmer edit section *** (ЗагрФайла.ЭксФайлы Set end)

                // *** End programmer edit section *** (ЗагрФайла.ЭксФайлы Set end)
            }
        }
        
        /// <summary>
        /// Загр файла.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрФайла.ТчЗагр CustomAttributes)

        // *** End programmer edit section *** (ЗагрФайла.ТчЗагр CustomAttributes)
        public virtual IIS.Kurs3.DetailArrayOfТчЗагр ТчЗагр
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрФайла.ТчЗагр Get start)

                // *** End programmer edit section *** (ЗагрФайла.ТчЗагр Get start)
                if ((this.fТчЗагр == null))
                {
                    this.fТчЗагр = new IIS.Kurs3.DetailArrayOfТчЗагр(this);
                }
                IIS.Kurs3.DetailArrayOfТчЗагр result = this.fТчЗагр;
                // *** Start programmer edit section *** (ЗагрФайла.ТчЗагр Get end)

                // *** End programmer edit section *** (ЗагрФайла.ТчЗагр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрФайла.ТчЗагр Set start)

                // *** End programmer edit section *** (ЗагрФайла.ТчЗагр Set start)
                this.fТчЗагр = value;
                // *** Start programmer edit section *** (ЗагрФайла.ТчЗагр Set end)

                // *** End programmer edit section *** (ЗагрФайла.ТчЗагр Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗагрФайлаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗагрФайлаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗагрФайлаE", typeof(IIS.Kurs3.ЗагрФайла));
                }
            }
            
            /// <summary>
            /// "ЗагрФайлаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗагрФайлаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗагрФайлаL", typeof(IIS.Kurs3.ЗагрФайла));
                }
            }
        }
    }
}
