
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Mvc.Razor;
using hackathon_21._04._23.Shared;

namespace hackathon_21._04._23
{
    public class ServicePageEngine
    {

        #region Работа с TablePageComponent
        /// <summary>
        /// Создание компонента таблицы
        /// </summary>
        /// <param name="Title">Название страницы</param>
        /// <param name="HeaderData">Список заголовков</param>
        /// <param name="AllData">Данные строк таблицы</param>
        /// <param name="NeedCreate">Нужна ли кнопка Создать</param>
        /// <param name="URLCreate">Ссылка на страницу создания</param>
        /// <param name="NeedRead">Нужна ли кнопка Реактировать</param>
        /// <param name="URLEdit">Ссылка на страницу Редактирования</param>
        /// <param name="NeedDelete">Нужна ли кнопка Удалить</param>
        /// <param name="URLDelete">Ссылка на страницу Удаления</param>
        /// <returns>Компонент таблица</returns>
        public RenderFragment GetTablePage(string Title, List<string> HeaderData, List<List<string>> AllData = null,
            bool NeedCreate = false,
            TablePage.TablePageSettings.methCreate methCreate = null,
            bool NeedRead = false,
            TablePage.TablePageSettings.methRead methRead = null,
            bool Needupdate = false,
            TablePage.TablePageSettings.methUpdate methUpdate = null,
            bool NeedDelete = false,
            TablePage.TablePageSettings.methDelete methDelete = null,
            bool NeedExtraOne = false,
            TablePage.TablePageSettings.methExtraOne methExtraOne = null
            )
        {
            string SettingsName = "settings";
            TablePage.TablePageSettings settings = new TablePage.TablePageSettings(
                Title, 
                HeaderData, 
                AllData,
                NeedCreate,
                methCreate,
                NeedRead,
                methRead,
                Needupdate,
                methUpdate,
                NeedDelete,
                methDelete,
                NeedExtraOne,
                methExtraOne);
            RenderFragment fragment() => builder =>
            {
                builder.OpenComponent(0, typeof(TablePage));
                builder.AddAttribute(1, SettingsName, settings);
                builder.CloseComponent();
            };

            return fragment();
        }

        /// <summary>
        /// Создание компонента таблицы
        /// <param name="tablePageSettings">Экземпляр класса настроек страницы</param>
        /// </summary>
        public RenderFragment GetTablePage(TablePage.TablePageSettings tablePageSettings)
        {
            string SettingsName = "settings";
            RenderFragment fragment() => builder =>
            {
                builder.OpenComponent(0, typeof(TablePage));
                builder.AddAttribute(1, SettingsName, tablePageSettings);
                builder.CloseComponent();
            };

            return fragment();
        }
        #endregion

        #region Работа с CRUDPageComponent
        public RenderFragment GetCRUDPage(CRUDPage.CRUDPageSettings cRUDPageSettings)
        {
            string SettingsName = "settings";
            RenderFragment fragment() => builder =>
            {
                builder.OpenComponent(0, typeof(CRUDPage));
                builder.AddAttribute(1, SettingsName, cRUDPageSettings);
                builder.CloseComponent();
            };

            return fragment();
        }


        #endregion

    }
}
