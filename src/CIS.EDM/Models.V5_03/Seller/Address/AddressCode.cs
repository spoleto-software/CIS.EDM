using System;
using System.Collections.Generic;

namespace CIS.EDM.Models.V5_03.Seller.Address
{
    /// <summary>
    /// Уникальный номер адреса объекта адресации в государственном адресном реестре
    /// </summary>
    public record AddressCode
    {
		/// <summary>
		/// Уникальный номер адреса объекта адресации в государственном адресном реестре в виде 36-разрядного GUID
		/// </summary>
		/// <value><b>ИдНом</b> - сокращенное наименование (код) элемента.</value>
		public Guid UniqueCode { get; set; }

		/// <summary>
		/// Почтовый индекс.
		/// </summary>
		/// <value><b>Индекс</b> - сокращенное наименование (код) элемента.</value>
		public string ZipCode { get; set; }

		/// <summary>
		/// Субъект Российской Федерации (код)
		/// </summary>
		/// <remarks>
		/// Принимает значение в соответствии с «Кодами субъектов Российской Федерации и иных территорий»
		/// </remarks>
		/// <value><b>Регион</b> - сокращенное наименование (код) элемента.</value>
		public string Region { get; set; }

		/// <summary>
		/// Наименование субъекта Российской Федерации
		/// </summary>
		/// <remarks>
		/// Принимает значение наименования субъекта в соответствии со справочником
		/// «Субъекты Российской Федерации» «Формат представления налоговой и бухгалтерской отчетности в электронном виде»,
		/// за следующим исключением: если код субъекта Российской Федерации принимает значение равным «99» (<see cref="Region"/>=99),
		/// то элемент принимает значение «иные территории, включая город и космодром Байконур»/</remarks>
		/// <value><b>НаимРегион</b> - сокращенное наименование (код) элемента.</value>
		public string RegionName { get; set; }

		/// <summary>
		/// Муниципальный район/ городской округ/ внутригородская территория города федерального значения/ муниципальный округ/ федеральная территория.
		/// </summary>
		/// <remarks>
		/// Обязателен, если <see cref="Region"/> не равен "99"
		/// </remarks>
		/// <value><b>МуниципРайон</b> - сокращенное наименование (код) элемента.</value>
		public AddressElementCode MunicipalDistrict { get; set; }

		/// <summary>
		/// Городское поселение/ сельское поселение/ межселенная территория в составе муниципального района/ внутригородской район городского округа.
		/// </summary>
		/// <value><b>ГородСелПоселен</b> - сокращенное наименование (код) элемента.</value>
		public AddressElementCode UrbanRuralSettlement { get; set; }

		/// <summary>
		/// Населенный пункт (город, деревня, село и прочее)
		/// </summary>
		/// <value><b>НаселенПункт</b> - сокращенное наименование (код) элемента.</value>
		public AddressElement Settlement { get; set; }

		/// <summary>
		/// Элемент планировочной структуры
		/// </summary>
		/// <value><b>ЭлПланСтруктур</b> - сокращенное наименование (код) элемента.</value>
		public AddressElementType PlanningStructureElement { get; set; }

		/// <summary>
		/// Элемент улично-дорожной сети
		/// </summary>
		/// <value><b>ЭлУлДорСети</b> - сокращенное наименование (код) элемента.</value>
		public AddressElementType StreetRoadNetworkElement { get; set; }

		/// <summary>
		/// Земельный участок (номер)
		/// </summary>
		/// <value><b>ЗемелУчасток</b> - сокращенное наименование (код) элемента.</value>
		public string LandPlotNumber { get; set; }

		/// <summary>
		/// Здание (строение), сооружение/ объект незавершенного строительства
		/// </summary>
		/// <value><b>Здание</b> - сокращенное наименование (код) элемента.</value>
		public List<AddressElementNumber> BuildingList { get; set; }

		/// <summary>
		/// Помещение в пределах здания (строения), сооружения/ машино-место
		/// </summary>
		/// <value><b>ПомещЗдания</b> - сокращенное наименование (код) элемента.</value>
		public AddressElementNumber BuildingRoom { get; set; }

		/// <summary>
		/// Помещение в пределах квартиры
		/// </summary>
		/// <value><b>ПомещКвартиры</b> - сокращенное наименование (код) элемента.</value>
		public AddressElementNumber ApartmentRoom { get; set; }

		/// <summary>
		/// Текстовое представление объекта.
		/// </summary>
		public override string ToString() => UniqueCode.ToString();
    }
}