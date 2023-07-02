// <auto-generated/>
#pragma warning disable
using DDS.Modules.Customers.Domain;
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
    // START: UpsertCustomerOperation740101857
    public class UpsertCustomerOperation740101857 : Marten.Internal.Operations.StorageOperation<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly DDS.Modules.Customers.Domain.Customer _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertCustomerOperation740101857(DDS.Modules.Customers.Domain.Customer document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_customer(?, ?, ?, ?)";


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


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session)
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

    // END: UpsertCustomerOperation740101857
    
    
    // START: InsertCustomerOperation740101857
    public class InsertCustomerOperation740101857 : Marten.Internal.Operations.StorageOperation<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly DDS.Modules.Customers.Domain.Customer _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertCustomerOperation740101857(DDS.Modules.Customers.Domain.Customer document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_customer(?, ?, ?, ?)";


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


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session)
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

    // END: InsertCustomerOperation740101857
    
    
    // START: UpdateCustomerOperation740101857
    public class UpdateCustomerOperation740101857 : Marten.Internal.Operations.StorageOperation<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly DDS.Modules.Customers.Domain.Customer _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateCustomerOperation740101857(DDS.Modules.Customers.Domain.Customer document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_customer(?, ?, ?, ?)";


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


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session)
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

    // END: UpdateCustomerOperation740101857
    
    
    // START: QueryOnlyCustomerSelector740101857
    public class QueryOnlyCustomerSelector740101857 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Domain.Customer>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyCustomerSelector740101857(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Domain.Customer Resolve(System.Data.Common.DbDataReader reader)
        {

            DDS.Modules.Customers.Domain.Customer document;
            document = _serializer.FromJson<DDS.Modules.Customers.Domain.Customer>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Domain.Customer> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DDS.Modules.Customers.Domain.Customer document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Domain.Customer>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyCustomerSelector740101857
    
    
    // START: LightweightCustomerSelector740101857
    public class LightweightCustomerSelector740101857 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DDS.Modules.Customers.Domain.Customer, System.Guid>, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Domain.Customer>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightCustomerSelector740101857(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Domain.Customer Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DDS.Modules.Customers.Domain.Customer document;
            document = _serializer.FromJson<DDS.Modules.Customers.Domain.Customer>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Domain.Customer> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DDS.Modules.Customers.Domain.Customer document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Domain.Customer>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightCustomerSelector740101857
    
    
    // START: IdentityMapCustomerSelector740101857
    public class IdentityMapCustomerSelector740101857 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DDS.Modules.Customers.Domain.Customer, System.Guid>, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Domain.Customer>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapCustomerSelector740101857(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Domain.Customer Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Domain.Customer document;
            document = _serializer.FromJson<DDS.Modules.Customers.Domain.Customer>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Domain.Customer> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Domain.Customer document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Domain.Customer>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapCustomerSelector740101857
    
    
    // START: DirtyTrackingCustomerSelector740101857
    public class DirtyTrackingCustomerSelector740101857 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DDS.Modules.Customers.Domain.Customer, System.Guid>, Marten.Linq.Selectors.ISelector<DDS.Modules.Customers.Domain.Customer>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingCustomerSelector740101857(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DDS.Modules.Customers.Domain.Customer Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Domain.Customer document;
            document = _serializer.FromJson<DDS.Modules.Customers.Domain.Customer>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DDS.Modules.Customers.Domain.Customer> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DDS.Modules.Customers.Domain.Customer document;
            document = await _serializer.FromJsonAsync<DDS.Modules.Customers.Domain.Customer>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingCustomerSelector740101857
    
    
    // START: QueryOnlyCustomerDocumentStorage740101857
    public class QueryOnlyCustomerDocumentStorage740101857 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyCustomerDocumentStorage740101857(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Domain.Customer document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Domain.Customer document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyCustomerSelector740101857(session, _document);
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

    // END: QueryOnlyCustomerDocumentStorage740101857
    
    
    // START: LightweightCustomerDocumentStorage740101857
    public class LightweightCustomerDocumentStorage740101857 : Marten.Internal.Storage.LightweightDocumentStorage<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightCustomerDocumentStorage740101857(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Domain.Customer document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Domain.Customer document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightCustomerSelector740101857(session, _document);
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

    // END: LightweightCustomerDocumentStorage740101857
    
    
    // START: IdentityMapCustomerDocumentStorage740101857
    public class IdentityMapCustomerDocumentStorage740101857 : Marten.Internal.Storage.IdentityMapDocumentStorage<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapCustomerDocumentStorage740101857(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Domain.Customer document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Domain.Customer document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapCustomerSelector740101857(session, _document);
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

    // END: IdentityMapCustomerDocumentStorage740101857
    
    
    // START: DirtyTrackingCustomerDocumentStorage740101857
    public class DirtyTrackingCustomerDocumentStorage740101857 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingCustomerDocumentStorage740101857(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DDS.Modules.Customers.Domain.Customer document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCustomerOperation740101857
            (
                document, Identity(document),
                session.Versions.ForType<DDS.Modules.Customers.Domain.Customer, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DDS.Modules.Customers.Domain.Customer document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DDS.Modules.Customers.Domain.Customer document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingCustomerSelector740101857(session, _document);
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

    // END: DirtyTrackingCustomerDocumentStorage740101857
    
    
    // START: CustomerBulkLoader740101857
    public class CustomerBulkLoader740101857 : Marten.Internal.CodeGeneration.BulkLoader<DDS.Modules.Customers.Domain.Customer, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DDS.Modules.Customers.Domain.Customer, System.Guid> _storage;

        public CustomerBulkLoader740101857(Marten.Internal.Storage.IDocumentStorage<DDS.Modules.Customers.Domain.Customer, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_customer(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_customer_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_customer (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_customer_temp.\"id\", mt_doc_customer_temp.\"data\", mt_doc_customer_temp.\"mt_version\", mt_doc_customer_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_customer_temp left join public.mt_doc_customer on mt_doc_customer_temp.id = public.mt_doc_customer.id where public.mt_doc_customer.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_customer target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_customer_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_customer_temp as select * from public.mt_doc_customer limit 0";


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


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DDS.Modules.Customers.Domain.Customer document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DDS.Modules.Customers.Domain.Customer document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
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

    // END: CustomerBulkLoader740101857
    
    
    // START: CustomerProvider740101857
    public class CustomerProvider740101857 : Marten.Internal.Storage.DocumentProvider<DDS.Modules.Customers.Domain.Customer>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public CustomerProvider740101857(Marten.Schema.DocumentMapping mapping) : base(new CustomerBulkLoader740101857(new QueryOnlyCustomerDocumentStorage740101857(mapping)), new QueryOnlyCustomerDocumentStorage740101857(mapping), new LightweightCustomerDocumentStorage740101857(mapping), new IdentityMapCustomerDocumentStorage740101857(mapping), new DirtyTrackingCustomerDocumentStorage740101857(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: CustomerProvider740101857
    
    
}
