//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "184ad87260292d32")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.7")]

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// footerText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("footerText")]
		public virtual string FooterText => this.Value<string>("footerText");

		///<summary>
		/// Hero Slider
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("heroSlider")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent HeroSlider => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("heroSlider");

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("logo")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops Logo => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("logo");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("description")]
		public virtual string Description => global::Umbraco.Web.PublishedModels.SEO.GetDescription(this);

		///<summary>
		/// Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("keywords")]
		public virtual string Keywords => global::Umbraco.Web.PublishedModels.SEO.GetKeywords(this);
	}

	// Mixin Content Type with alias "sEO"
	/// <summary>SEO</summary>
	public partial interface ISEO : IPublishedContent
	{
		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		string Description { get; }

		/// <summary>Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		string Keywords { get; }
	}

	/// <summary>SEO</summary>
	[PublishedModel("sEO")]
	public partial class SEO : PublishedContentModel, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "sEO";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEO, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SEO(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("description")]
		public virtual string Description => GetDescription(this);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static string GetDescription(ISEO that) => that.Value<string>("description");

		///<summary>
		/// Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("keywords")]
		public virtual string Keywords => GetKeywords(this);

		/// <summary>Static getter for Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static string GetKeywords(ISEO that) => that.Value<string>("keywords");
	}

	/// <summary>Page</summary>
	[PublishedModel("page")]
	public partial class Page : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "page";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Page(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// HeroImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("heroImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops HeroImage => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("heroImage");

		///<summary>
		/// PageTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>("pageTitle");

		///<summary>
		/// SubTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("subTitle")]
		public virtual string SubTitle => this.Value<string>("subTitle");
	}

	/// <summary>Product</summary>
	[PublishedModel("product")]
	public partial class Product : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "product";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Product, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Product(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Product Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("productDescription")]
		public virtual string ProductDescription => this.Value<string>("productDescription");

		///<summary>
		/// ProductImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("productImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops ProductImage => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("productImage");

		///<summary>
		/// ProductPrice
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("productPrice")]
		public virtual decimal ProductPrice => this.Value<decimal>("productPrice");

		///<summary>
		/// ProductTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("productTitle")]
		public virtual string ProductTitle => this.Value<string>("productTitle");

		///<summary>
		/// Rating
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("rating")]
		public virtual int Rating => this.Value<int>("rating");
	}

	/// <summary>Carousel</summary>
	[PublishedModel("carousel")]
	public partial class Carousel : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "carousel";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Carousel, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Carousel(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("image")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops Image => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("image");

		///<summary>
		/// SubTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("subTitle")]
		public virtual string SubTitle => this.Value<string>("subTitle");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("title")]
		public virtual string Title => this.Value<string>("title");
	}

	/// <summary>Data</summary>
	[PublishedModel("data")]
	public partial class Data : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "data";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Data, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Data(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Carousles</summary>
	[PublishedModel("carousles")]
	public partial class Carousles : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "carousles";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Carousles, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Carousles(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Folder</summary>
	[PublishedModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "Folder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Folder(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Image</summary>
	[PublishedModel("Image")]
	public partial class Image : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "Image";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Image(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoFile")]
		public virtual global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue UmbracoFile => this.Value<global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue>("umbracoFile");

		///<summary>
		/// Height: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoHeight")]
		public virtual int UmbracoHeight => this.Value<int>("umbracoHeight");

		///<summary>
		/// Width: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoWidth")]
		public virtual int UmbracoWidth => this.Value<int>("umbracoWidth");
	}

	/// <summary>File</summary>
	[PublishedModel("File")]
	public partial class File : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "File";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public File(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// File
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoFile")]
		public virtual string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Video</summary>
	[PublishedModel("umbracoMediaVideo")]
	public partial class UmbracoMediaVideo : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "umbracoMediaVideo";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoMediaVideo, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UmbracoMediaVideo(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Video
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoFile")]
		public virtual string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Audio</summary>
	[PublishedModel("umbracoMediaAudio")]
	public partial class UmbracoMediaAudio : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "umbracoMediaAudio";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoMediaAudio, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UmbracoMediaAudio(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Audio
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoFile")]
		public virtual string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Article</summary>
	[PublishedModel("umbracoMediaArticle")]
	public partial class UmbracoMediaArticle : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "umbracoMediaArticle";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoMediaArticle, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UmbracoMediaArticle(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Article
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoFile")]
		public virtual string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Vector Graphics (SVG)</summary>
	[PublishedModel("umbracoMediaVectorGraphics")]
	public partial class UmbracoMediaVectorGraphics : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "umbracoMediaVectorGraphics";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoMediaVectorGraphics, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UmbracoMediaVectorGraphics(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Vector Graphics
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoFile")]
		public virtual string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Member</summary>
	[PublishedModel("Member")]
	public partial class Member : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const string ModelTypeAlias = "Member";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Member(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Approved
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberApproved")]
		public virtual bool UmbracoMemberApproved => this.Value<bool>("umbracoMemberApproved");

		///<summary>
		/// Comments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberComments")]
		public virtual string UmbracoMemberComments => this.Value<string>("umbracoMemberComments");

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public virtual int UmbracoMemberFailedPasswordAttempts => this.Value<int>("umbracoMemberFailedPasswordAttempts");

		///<summary>
		/// Last Lockout Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public virtual global::System.DateTime UmbracoMemberLastLockoutDate => this.Value<global::System.DateTime>("umbracoMemberLastLockoutDate");

		///<summary>
		/// Last Login Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public virtual global::System.DateTime UmbracoMemberLastLogin => this.Value<global::System.DateTime>("umbracoMemberLastLogin");

		///<summary>
		/// Last Password Change Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public virtual global::System.DateTime UmbracoMemberLastPasswordChangeDate => this.Value<global::System.DateTime>("umbracoMemberLastPasswordChangeDate");

		///<summary>
		/// Is Locked Out
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public virtual bool UmbracoMemberLockedOut => this.Value<bool>("umbracoMemberLockedOut");

		///<summary>
		/// Password Answer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public virtual global::System.DateTime UmbracoMemberPasswordRetrievalAnswer => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalAnswer");

		///<summary>
		/// Password Question
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.4")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public virtual global::System.DateTime UmbracoMemberPasswordRetrievalQuestion => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalQuestion");
	}

}
