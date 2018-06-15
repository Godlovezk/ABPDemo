(function () {

    $(function () {
        var _personService = abp.services.app.person;

        var _$modal = $("#PersonCreateModal")

        var _$form = _$modal.find('form');

        //添加联系人功能
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();  //禁用默认提交事件
            if (!_$form.valid()) {
                return;    //判定表单验证是否通过
            }
            var personEditDto = _$form.serializeFormToObject();  //序列化表单为对象

            abp.ui.setBusy(_$modal);  //设置提交页面为忙碌状态
            //约定大于配置
            _personService.creatOrUpdatePerson({ personEditDto }).done(function () {
                _$modal.modal('hide'); //窗口隐藏
                location.reload();
            }).always(function () {
                abp.ui.clearBusy(_$modal);
                });


        });
    });




})();