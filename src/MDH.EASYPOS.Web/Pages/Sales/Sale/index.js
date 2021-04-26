$(function () {

    var l = abp.localization.getResource('EASYPOS');

    var service = mDH.eASYPOS.sales.sale;
    var createModal = new abp.ModalManager(abp.appPath + 'Sales/Sale/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Sales/Sale/EditModal');

    var dataTable = $('#SaleTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('EASYPOS.Sale.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('EASYPOS.Sale.Delete'),
                                confirmMessage: function (data) {
                                    return l('SaleDeletionConfirmationMessage', data.record.id);
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
                title: l('SaleSubtotal'),
                data: "subtotal"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSaleButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
