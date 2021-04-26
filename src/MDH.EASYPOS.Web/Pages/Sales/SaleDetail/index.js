$(function () {

    var l = abp.localization.getResource('EASYPOS');

    var service = mDH.eASYPOS.sales.saleDetail;
    var createModal = new abp.ModalManager(abp.appPath + 'Sales/SaleDetail/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Sales/SaleDetail/EditModal');

    var dataTable = $('#SaleDetailTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('EASYPOS.SaleDetail.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('EASYPOS.SaleDetail.Delete'),
                                confirmMessage: function (data) {
                                    return l('SaleDetailDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('SaleDetailSaleId'),
                data: "saleId"
            },
            {
                title: l('SaleDetailTotal'),
                data: "total"
            },
            {
                title: l('SaleDetailCount'),
                data: "count"
            },
            {
                title: l('SaleDetailUnitPrice'),
                data: "unitPrice"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSaleDetailButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
