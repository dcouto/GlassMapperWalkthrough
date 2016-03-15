using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper;
using Glass.Mapper.Pipelines.ConfigurationResolver;
using Glass.Mapper.Sc;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using Config = Glass.Mapper.Sc.Config;
using Version = Sitecore.Data.Version;

namespace GlassMapperWalkthrough.Web.Tests.Models.Glass.Mapper.Sc
{
    public class MockSitecoreContext : ISitecoreContext
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object InstantiateObject(AbstractTypeCreationContext abstractTypeCreationContext)
        {
            throw new NotImplementedException();
        }

        AbstractDataMappingContext ISitecoreService.CreateDataMappingContext(AbstractTypeCreationContext abstractTypeCreationContext, object obj)
        {
            throw new NotImplementedException();
        }

        AbstractDataMappingContext ISitecoreService.CreateDataMappingContext(AbstractTypeSavingContext creationContext)
        {
            throw new NotImplementedException();
        }

        public void SaveObject(AbstractTypeSavingContext abstractTypeSavingContext)
        {
            throw new NotImplementedException();
        }

        public Item ResolveItem(object target)
        {
            throw new NotImplementedException();
        }

        public Database Database { get; private set; }
        public Config Config { get; set; }

        public T AddVersion<T>(T target) where T : class
        {
            throw new NotImplementedException();
        }

        public T Create<T, TK>(TK parent, T newItem, bool updateStatistics = true, bool silent = false) where T : class where TK : class
        {
            throw new NotImplementedException();
        }

        public T Create<T, TK>(TK parent, string newName, Language language = null, bool updateStatistics = true, bool silent = false) where T : class where TK : class
        {
            throw new NotImplementedException();
        }

        public object CreateType(Type type, Item item, bool isLazy, bool inferType, Dictionary<string, object> parameters,
            params object[] constructorParameters)
        {
            throw new NotImplementedException();
        }

        public T CreateType<T>(Item item, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T Cast<T>(Item item, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T CreateType<T, TK>(Item item, TK param1, bool isLazy = false, bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public T CreateType<T, TK, TL>(Item item, TK param1, TL param2, bool isLazy = false, bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public T CreateType<T, TK, TL, TM>(Item item, TK param1, TL param2, TM param3, bool isLazy = false, bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public T CreateType<T, TK, TL, TM, TN>(Item item, TK param1, TL param2, TM param3, TN param4, bool isLazy = false,
            bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public T CreateType<T, TK, TL, TM, TN, TO>(Item item, TK param1, TL param2, TM param3, TN param4, TO param5,
            bool isLazy = false, bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public T CreateType<T>(Item item, bool isLazy = false, bool inferType = false, params object[] constructorParameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable CreateTypes(Type type, Func<IEnumerable<Item>> getItems, bool isLazy = false, bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }

        public dynamic GetDynamicItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public dynamic GetDynamicItem(string path)
        {
            throw new NotImplementedException();
        }

        public dynamic GetDynamicItem(Item item)
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(string path, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL>(string path, TK param1, TL param2, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM>(string path, TK param1, TL param2, TM param3, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM, TN>(string path, TK param1, TL param2, TM param3, TN param4, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK>(string path, TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(string path, Language language, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK>(string path, Language language, TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL>(string path, Language language, TK param1, TL param2, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM>(string path, Language language, TK param1, TL param2, TM param3, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM, TN>(string path, Language language, TK param1, TL param2, TM param3, TN param4,
            bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(string path, Language language, Version version, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK>(string path, Language language, Version version, TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL>(string path, Language language, Version version, TK param1, TL param2, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM>(string path, Language language, Version version, TK param1, TL param2, TM param3,
            bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM, TN>(string path, Language language, Version version, TK param1, TL param2, TM param3, TN param4,
            bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(Guid id, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK>(Guid id, TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL>(Guid id, TK param1, TL param2, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM>(Guid id, TK param1, TL param2, TM param3, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM, TN>(Guid id, TK param1, TL param2, TM param3, TN param4, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(Guid id, Language language, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK>(Guid id, Language language, TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL>(Guid id, Language language, TK param1, TL param2, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM>(Guid id, Language language, TK param1, TL param2, TM param3, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM, TN>(Guid id, Language language, TK param1, TL param2, TM param3, TN param4, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(Guid id, Language language, Version version, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK>(Guid id, Language language, Version version, TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL>(Guid id, Language language, Version version, TK param1, TL param2, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM>(Guid id, Language language, Version version, TK param1, TL param2, TM param3,
            bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItem<T, TK, TL, TM, TN>(Guid id, Language language, Version version, TK param1, TL param2, TM param3, TN param4,
            bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK, TL, TM, TN>(Guid id, Language language = null, Version version = null,
            bool isLazy = false, bool inferType = false) where T : class where TK : class where TL : class where TM : class where TN : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK, TL, TM>(Guid id, Language language = null, Version version = null, bool isLazy = false,
            bool inferType = false) where T : class where TK : class where TL : class where TM : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK, TL>(Guid id, Language language = null, Version version = null, bool isLazy = false,
            bool inferType = false) where T : class where TK : class where TL : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK>(Guid id, Language language = null, Version version = null, bool isLazy = false,
            bool inferType = false) where T : class where TK : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK, TL, TM, TN>(string path, Language language = null, Version version = null,
            bool isLazy = false, bool inferType = false) where T : class where TK : class where TL : class where TM : class where TN : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK, TL, TM>(string path, Language language = null, Version version = null,
            bool isLazy = false, bool inferType = false) where T : class where TK : class where TL : class where TM : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK, TL>(string path, Language language = null, Version version = null, bool isLazy = false,
            bool inferType = false) where T : class where TK : class where TL : class
        {
            throw new NotImplementedException();
        }

        public T GetItemWithInterfaces<T, TK>(string path, Language language = null, Version version = null, bool isLazy = false,
            bool inferType = false) where T : class where TK : class
        {
            throw new NotImplementedException();
        }

        public void Move<T, TK>(T item, TK newParent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string query, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string query, Language language, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T QuerySingle<T>(string query, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public void Save<T>(T target, bool updateStatistics = true, bool silent = false)
        {
            throw new NotImplementedException();
        }

        public void WriteToItem<T>(T target, Item item, bool updateStatistics = true, bool silent = false)
        {
            throw new NotImplementedException();
        }

        public void Map<T>(T target)
        {
            throw new NotImplementedException();
        }

        AbstractDataMappingContext IAbstractService.CreateDataMappingContext(AbstractTypeCreationContext creationContext, object obj)
        {
            throw new NotImplementedException();
        }

        AbstractDataMappingContext IAbstractService.CreateDataMappingContext(AbstractTypeSavingContext creationContext)
        {
            throw new NotImplementedException();
        }

        public ConfigurationResolverArgs RunConfigurationPipeline(AbstractTypeCreationContext abstractTypeCreationContext)
        {
            throw new NotImplementedException();
        }

        public Context GlassContext { get; private set; }
        public bool CacheEnabled { get; set; }
        public T GetCurrentItem<T>(bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetCurrentItem<T, TK>(TK param1, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetCurrentItem<T, TK, TL>(TK param1, TL param2, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetCurrentItem<T, TK, TL, TM>(TK param1, TL param2, TM param3, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetCurrentItem<T, TK, TL, TM, TN>(TK param1, TL param2, TM param3, TN param4, bool isLazy = false,
            bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public object GetCurrentItem(Type type, bool isLazy = false, bool inferType = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> QueryRelative<T>(string query, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T QuerySingleRelative<T>(string query, bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetHomeItem<T>(bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetRootItem<T>(bool isLazy = false, bool inferType = false) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
