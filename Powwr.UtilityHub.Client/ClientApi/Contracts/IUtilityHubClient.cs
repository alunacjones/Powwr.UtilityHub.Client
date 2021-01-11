namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using UD.UtilityHub.Api.Contracts;

    [GeneratedCode("NSwag", "13.9.4.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public interface IUtilityHubClient
    {
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Brokerage_AssignBrokerageSupplier(int brokerageId, AssignBrokerageSupplierModel model);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Brokerage_AssignBrokerageSupplierAsync(
            int brokerageId,
            AssignBrokerageSupplierModel model,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Brokerage_GetBrokerage(string externalId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        FileResponse Brokerage_GetBrokerage2(int brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        Task<FileResponse> Brokerage_GetBrokerage2Async(
            int brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Brokerage_GetBrokerageAsync(
            string externalId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        FileResponse Brokerage_GetBrokerages();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        Task<FileResponse> Brokerage_GetBrokeragesAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Brokerage_GetBrokeragesForExternal();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Brokerage_GetBrokeragesForExternalAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<BrokerageNameExternalIdModel>> Brokerage_GetBrokeragesNameExternalIds();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<BrokerageNameExternalIdModel>>> Brokerage_GetBrokeragesNameExternalIdsAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        UtilityHubResponse<ICollection<BrokerageNameIdModel>> Brokerage_GetBrokeragesNameIds();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        Task<UtilityHubResponse<ICollection<BrokerageNameIdModel>>> Brokerage_GetBrokeragesNameIdsAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Brokerage_RevokeBrokerageSupplier(int brokerageId, AssignBrokerageSupplierModel model);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Brokerage_RevokeBrokerageSupplierAsync(
            int brokerageId,
            AssignBrokerageSupplierModel model,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<int> BrokerageManagement_CheckCompanyNumber(string companyNumber, int? legalEntityId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<int>> BrokerageManagement_CheckCompanyNumberAsync(
            string companyNumber,
            int? legalEntityId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<bool> BrokerageManagement_CheckVanityName(string vanityName, int? brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<bool>> BrokerageManagement_CheckVanityNameAsync(
            string vanityName,
            int? brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<BrokerageEditModel> BrokerageManagement_Get(int brokerageId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<BrokerageIndexModel>> BrokerageManagement_GetAll();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<BrokerageIndexModel>>> BrokerageManagement_GetAllAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<BrokerageEditModel>> BrokerageManagement_GetAsync(
            int brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse BrokerageManagement_GetBrokerageExternalId(int brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> BrokerageManagement_GetBrokerageExternalIdAsync(
            int brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse BrokerageManagement_Post(BrokerageEditModel brokerage);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> BrokerageManagement_PostAsync(
            BrokerageEditModel brokerage,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse BulkImport_BulkBrokerageImport(int supplierId, int legalEntityId, FileParameter file = null);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> BulkImport_BulkBrokerageImportAsync(
            int supplierId,
            int legalEntityId,
            FileParameter file = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<CountryModel>> Country_Countries(string controller);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<CountryModel>>> Country_CountriesAsync(
            string controller,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<TimeZoneModel>> Country_Timezones(string controller);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<TimeZoneModel>>> Country_TimezonesAsync(
            string controller,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Organisation_GetCompanyNames();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Organisation_GetCompanyNamesAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Organisation_GetLegalEntity(int legalEntityId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Organisation_GetLegalEntityAsync(
            int legalEntityId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Product_GetProductConfiguration(string productId, GetProductConfigurationRequest request);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        FileResponse Product_GetProductConfiguration2(
            string productId,
            string hostName = null,
            int? supplierId = null,
            string supplierExternalId = null);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        Task<FileResponse> Product_GetProductConfiguration2Async(
            string productId,
            string hostName = null,
            int? supplierId = null,
            string supplierExternalId = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Product_GetProductConfigurationAsync(
            string productId,
            GetProductConfigurationRequest request,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<bool> Product_VerifyProductAccess(string productId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<bool>> Product_VerifyProductAccessAsync(
            string productId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<bool> ProductManagement_Delete(string productId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<bool> ProductManagement_Delete2(string productId, int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<bool>> ProductManagement_Delete2Async(
            string productId,
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<bool>> ProductManagement_DeleteAsync(
            string productId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ProductEditModel> ProductManagement_Get(string productId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<ProductIndexModel>> ProductManagement_GetAll();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<ProductIndexModel>>> ProductManagement_GetAllAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ProductEditModel>> ProductManagement_GetAsync(
            string productId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse ProductManagement_Post(ProductEditModel product);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> ProductManagement_PostAsync(
            ProductEditModel product,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ProductEditSupplierAssignmentModel> ProductManagement_ProductSupplierAssignment(
            string productId,
            int supplierId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse ProductManagement_ProductSupplierAssignment2(ProductEditSupplierAssignmentModel productAssignment);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> ProductManagement_ProductSupplierAssignment2Async(
            ProductEditSupplierAssignmentModel productAssignment,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<ProductSupplierAssignmentIndexModel>> ProductManagement_ProductSupplierAssignmentAll(
            string productId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<ProductSupplierAssignmentIndexModel>>>
            ProductManagement_ProductSupplierAssignmentAllAsync(
                string productId,
                CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ProductEditSupplierAssignmentModel>> ProductManagement_ProductSupplierAssignmentAsync(
            string productId,
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse ProductManagement_ProductSupplierBrokerageConfiguration(
            ProductEditSupplierBrokerageAssignmentModel productAssignment,
            string supplierId,
            string brokerageId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ProductEditSupplierBrokerageAssignmentModel>
            ProductManagement_ProductSupplierBrokerageConfiguration2(string productId, int supplierId, int brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ProductEditSupplierBrokerageAssignmentModel>>
            ProductManagement_ProductSupplierBrokerageConfiguration2Async(
                string productId,
                int supplierId,
                int brokerageId,
                CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> ProductManagement_ProductSupplierBrokerageConfigurationAsync(
            ProductEditSupplierBrokerageAssignmentModel productAssignment,
            string supplierId,
            string brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse ProductManagement_UploadLogo(FileParameter file = null);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> ProductManagement_UploadLogoAsync(
            FileParameter file = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Supplier_GetSupplier(string externalId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        FileResponse Supplier_GetSupplier2(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        Task<FileResponse> Supplier_GetSupplier2Async(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Supplier_GetSupplierAsync(
            string externalId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Supplier_GetSupplierConfiguration(string externalId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Supplier_GetSupplierConfigurationAsync(
            string externalId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        FileResponse Supplier_GetSuppliers();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        [Obsolete]
        Task<FileResponse> Supplier_GetSuppliersAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse Supplier_GetSuppliersExternal();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> Supplier_GetSuppliersExternalAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_AssignedBrokerages(int supplierId, BrokerageSupplierModel brokerageSuppliers);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<BrokerageSupplierModel>> SupplierManagement_AssignedBrokeragesAll(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<BrokerageSupplierModel>>> SupplierManagement_AssignedBrokeragesAllAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_AssignedBrokeragesAsync(
            int supplierId,
            BrokerageSupplierModel brokerageSuppliers,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<bool> SupplierManagement_CheckVanityName(string vanityName, int? supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<bool>> SupplierManagement_CheckVanityNameAsync(
            string vanityName,
            int? supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_CreateSupplier(SupplierEditModel createSupplierModel);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_CreateSupplierAsync(
            SupplierEditModel createSupplierModel,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<SupplierEditModel> SupplierManagement_Get(int supplierId);

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<SupplierIndexModel>> SupplierManagement_GetAll();

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<SupplierIndexModel>>> SupplierManagement_GetAllAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<SupplierEditModel>> SupplierManagement_GetAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_GetSupplierConfiguration(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_GetSupplierConfigurationAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_GetSupplierExternalId(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_GetSupplierExternalIdAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_GetSupplierProductConfiguration(int supplierId, string productId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_GetSupplierProductConfigurationAsync(
            int supplierId,
            string productId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_GetSupplierProducts(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_GetSupplierProductsAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<SupplierEditModel> SupplierManagement_Post(SupplierEditModel supplier);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<SupplierEditModel>> SupplierManagement_PostAsync(
            SupplierEditModel supplier,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_SaveSupplierConfiguration(int supplierId, object configurationObject);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_SaveSupplierConfigurationAsync(
            int supplierId,
            object configurationObject,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse SupplierManagement_UnassignedBrokerage(int supplierLegalEntityId, int brokerageLegalEntityId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> SupplierManagement_UnassignedBrokerageAsync(
            int supplierLegalEntityId,
            int brokerageLegalEntityId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<ICollection<BrokerageEditModel>> SupplierManagement_UnassignedBrokerages(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<ICollection<BrokerageEditModel>>> SupplierManagement_UnassignedBrokeragesAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserIdentity_GetUser(Guid userId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserIdentity_GetUserAsync(
            Guid userId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserIdentity_GetUserBrokerage(Guid userId, int brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserIdentity_GetUserBrokerageAsync(
            Guid userId,
            int brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserIdentity_GetUsers(IEnumerable<Guid> userIds);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserIdentity_GetUsersAsync(
            IEnumerable<Guid> userIds,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserIdentity_GetUsersBySupplierId(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserIdentity_GetUsersBySupplierIdAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserIdentity_GetUserSupplier(Guid userId, int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserIdentity_GetUserSupplierAsync(
            Guid userId,
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_BrokerageAddUsers(int brokerageId, UserSelectionModel usersToAdd);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_BrokerageAddUsersAsync(
            int brokerageId,
            UserSelectionModel usersToAdd,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_BrokerageUnassignedUsers(int brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_BrokerageUnassignedUsersAsync(
            int brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_BrokerageUsers(int brokerageId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_BrokerageUsersAsync(
            int brokerageId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_BulkUserAssign(IEnumerable<int> brokerIds, string userEmail, string role);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_BulkUserAssignAsync(
            IEnumerable<int> brokerIds,
            string userEmail,
            string role,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_BulkUserImport(
            FileParameter file = null,
            bool? sendConfirmationEmail = null,
            string inviteBy = null,
            string productName = null,
            string organisationName = null,
            string portfolioName = null);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_BulkUserImportAsync(
            FileParameter file = null,
            bool? sendConfirmationEmail = null,
            string inviteBy = null,
            string productName = null,
            string organisationName = null,
            string portfolioName = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_ChangeBrokerageUserRole(int brokerageId, UserSelectionModel users);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_ChangeBrokerageUserRoleAsync(
            int brokerageId,
            UserSelectionModel users,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_ChangeSupplierUserRole(int supplierId, UserSelectionModel users);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_ChangeSupplierUserRoleAsync(
            int supplierId,
            UserSelectionModel users,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_DeactivateUser(Guid userId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_DeactivateUserAsync(
            Guid userId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UserModel[] UserManagement_GetAllUsers();

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UserModel UserManagement_GetUserById(Guid userId);

        /// <param name="userId"></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UserModel> UserManagement_GetUserByIdAsync(
            Guid userId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UserModel[]> UserManagement_GetAllUsersAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_LeaveBrokerage(Guid userId, UserBrokerageModel brokerage);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_LeaveBrokerageAsync(
            Guid userId,
            UserBrokerageModel brokerage,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_LeaveSupplier(Guid userId, UserSupplierModel supplier);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_LeaveSupplierAsync(
            Guid userId,
            UserSupplierModel supplier,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        UtilityHubResponse<UserModel> UserManagement_PostUser(CreateUserModel createUserModel);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<UtilityHubResponse<UserModel>> UserManagement_PostUserAsync(
            CreateUserModel createUserModel,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_ReactivateUser(Guid userId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_ReactivateUserAsync(
            Guid userId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_SendUserInvites(BulkUserInviteViewModel invites);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_SendUserInvitesAsync(
            BulkUserInviteViewModel invites,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_SupplierAddUsers(int supplierId, UserSelectionModel usersToAdd);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_SupplierAddUsersAsync(
            int supplierId,
            UserSelectionModel usersToAdd,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_SupplierUnassignedUsers(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_SupplierUnassignedUsersAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_SupplierUsers(int supplierId);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_SupplierUsersAsync(
            int supplierId,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_Update(UpdateUserModel updateUserModel);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_UpdateUserAsync(
            UpdateUserModel updateUserModel,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_UpdateEmail(UpdateUserEmailModel updateUserModel);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_UpdateEmailAsync(
            UpdateUserEmailModel updateUserModel,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        FileResponse UserManagement_UpdateUserEmailWebhook(UpdateEmailWebhookRequest request);

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <exception cref="UtilityHubApiException">A server side error occurred.</exception>
        Task<FileResponse> UserManagement_UpdateUserEmailWebhookAsync(
            UpdateEmailWebhookRequest request,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}