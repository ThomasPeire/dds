// <auto-generated/>
#pragma warning disable
using DDS.Modules.Customers.Application.Models;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertCustomerViewOperation1919837020
    public class UpsertCustomerViewOperation1919837020 : Marten.Internal.Operations.StorageOperation<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly DDS.Modules.Customers.Application.Models.CustomerView _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertCustomerViewOperation1919837020(DDS.Modules.Customers.Application.Models.CustomerView document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_customerview(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpsertCustomerViewOperation1919837020
    
    
    // START: InsertCustomerViewOperation1919837020
    public class InsertCustomerViewOperation1919837020 : Marten.Internal.Operations.StorageOperation<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly DDS.Modules.Customers.Application.Models.CustomerView _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertCustomerViewOperation1919837020(DDS.Modules.Customers.Application.Models.CustomerView document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_customerview(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: InsertCustomerViewOperation1919837020
    
    
    // START: UpdateCustomerViewOperation1919837020
    public class UpdateCustomerViewOperation1919837020 : Marten.Internal.Operations.StorageOperation<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly DDS.Modules.Customers.Application.Models.CustomerView _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateCustomerViewOperation1919837020(DDS.Modules.Customers.Application.Models.CustomerView document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_customerview(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpdateCustomerViewOperation1919837020
    
    
    // START: QueryOnlyCustomerViewSelector1919837020
    public class QueryOnlyCustomerViewSelector1919837020 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Application.Models.CustomerView>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyCustomerViewSelector1919837020(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Application.Models.CustomerView Resolve(System.Data.Common.DbDataReader reader)
        {

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = _serializer.FromJson<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Application.Models.CustomerView> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyCustomerViewSelector1919837020
    
    
    // START: LightweightCustomerViewSelector1919837020
    public class LightweightCustomerViewSelector1919837020 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Application.Models.CustomerView>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightCustomerViewSelector1919837020(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Application.Models.CustomerView Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = _serializer.FromJson<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Application.Models.CustomerView> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightCustomerViewSelector1919837020
    
    
    // START: IdentityMapCustomerViewSelector1919837020
    public class IdentityMapCustomerViewSelector1919837020 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Application.Models.CustomerView>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapCustomerViewSelector1919837020(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Application.Models.CustomerView Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = _serializer.FromJson<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Application.Models.CustomerView> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapCustomerViewSelector1919837020
    
    
    // START: DirtyTrackingCustomerViewSelector1919837020
    public class DirtyTrackingCustomerViewSelector1919837020 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Application.Models.CustomerView>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingCustomerViewSelector1919837020(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Application.Models.CustomerView Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = _serializer.FromJson<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Application.Models.CustomerView> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Application.Models.CustomerView document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Application.Models.CustomerView>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingCustomerViewSelector1919837020
    
    
    // START: QueryOnlyCustomerViewDocumentStorage1919837020
    public class QueryOnlyCustomerViewDocumentStorage1919837020 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyCustomerViewDocumentStorage1919837020(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Application.Models.CustomerView document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Application.Models.CustomerView document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyCustomerViewSelector1919837020(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyCustomerViewDocumentStorage1919837020
    
    
    // START: LightweightCustomerViewDocumentStorage1919837020
    public class LightweightCustomerViewDocumentStorage1919837020 : Marten.Internal.Storage.LightweightDocumentStorage<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightCustomerViewDocumentStorage1919837020(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Application.Models.CustomerView document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Application.Models.CustomerView document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightCustomerViewSelector1919837020(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightCustomerViewDocumentStorage1919837020
    
    
    // START: IdentityMapCustomerViewDocumentStorage1919837020
    public class IdentityMapCustomerViewDocumentStorage1919837020 : Marten.Internal.Storage.IdentityMapDocumentStorage<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapCustomerViewDocumentStorage1919837020(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Application.Models.CustomerView document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Application.Models.CustomerView document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapCustomerViewSelector1919837020(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapCustomerViewDocumentStorage1919837020
    
    
    // START: DirtyTrackingCustomerViewDocumentStorage1919837020
    public class DirtyTrackingCustomerViewDocumentStorage1919837020 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingCustomerViewDocumentStorage1919837020(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Application.Models.CustomerView document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerViewOperation1919837020
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Application.Models.CustomerView document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingCustomerViewSelector1919837020(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingCustomerViewDocumentStorage1919837020
    
    
    // START: CustomerViewBulkLoader1919837020
    public class CustomerViewBulkLoader1919837020 : Marten.Internal.CodeGeneration.BulkLoader<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid> _storage;

        public CustomerViewBulkLoader1919837020(Marten.Internal.Storage.IDocumentStorage<DDS.Modules.Customers.Application.Models.CustomerView, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_customerview(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_customerview_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_customerview (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_customerview_temp.\"id\", mt_doc_customerview_temp.\"data\", mt_doc_customerview_temp.\"mt_version\", mt_doc_customerview_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_customerview_temp left join public.mt_doc_customerview on mt_doc_customerview_temp.id = public.mt_doc_customerview.id where public.mt_doc_customerview.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_customerview target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_customerview_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_customerview_temp as select * from public.mt_doc_customerview limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DDS.Modules.Customers.Application.Models.CustomerView document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: CustomerViewBulkLoader1919837020
    
    
    // START: CustomerViewProvider1919837020
    public class CustomerViewProvider1919837020 : Marten.Internal.Storage.DocumentProvider<DDS.Modules.Customers.Application.Models.CustomerView>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public CustomerViewProvider1919837020(Marten.Schema.DocumentMapping mapping) : base(new CustomerViewBulkLoader1919837020(new QueryOnlyCustomerViewDocumentStorage1919837020(mapping)), new QueryOnlyCustomerViewDocumentStorage1919837020(mapping), new LightweightCustomerViewDocumentStorage1919837020(mapping), new IdentityMapCustomerViewDocumentStorage1919837020(mapping), new DirtyTrackingCustomerViewDocumentStorage1919837020(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: CustomerViewProvider1919837020
    
    
}

