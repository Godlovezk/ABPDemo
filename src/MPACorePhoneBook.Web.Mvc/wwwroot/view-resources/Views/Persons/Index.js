
(function () {
    $(function () {
        var _personService = abp.services.app.person;

        var _$modal = $("#PersonCreateModal");

        var _$form = _$modal.find('form');

        //添加联系人功能
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();  //禁用默认提交事件
            if (!_$form.valid()) {
                return;    //判定表单验证是否通过
            }
            var personEditDto = _$form.serializeFormToObject();  //序列化表单为对象
            personEditDto.PhoneNumbers = [];
            var phoneNumber = {};
            phoneNumber.PhoneType= personEditDto.PhoneNumberType;
            phoneNumber.Number = personEditDto.PhoneNumber;
            personEditDto.PhoneNumbers.push(phoneNumber);


            abp.ui.setBusy(_$modal);  //设置提交页面为忙碌状态
            //约定大于配置
            _personService.creatOrUpdatePerson({ personEditDto }).done(function () {
                _$modal.modal('hide'); //窗口隐藏
                refreshPersonList();
            }).always(function () {
                abp.ui.clearBusy(_$modal);
                });
        });
        // end add
        $('#RefreshButton').click(function () {
            refreshPersonList();
        });

        function refreshPersonList() {
            location.reload();
        }
        //删除联系人信息
        $('.delete-person').click(function () {
            var personId = $(this).attr("data-person-id");
            var personName = $(this).attr("data-person-name");
            deletePerson(personId, personName);
        });

        function deletePerson(id, name) {
            abp.message.confirm("是否删除姓名为" + name + "id 为" + id + "的联系人", function (isConfirmed) {
                if (isConfirmed) {
                    _personService.deletePerson({ id }).done(function () {
                        refreshPersonList();
                    })
                }
            });
        };
        //编辑联系人信息
        $('.edit-person').click(function (e) {
            e.preventDefault();
            var personId = $(this).attr("data-person-id");
            _personService.getPersonForEdit({ id: personId }).done(function (data) {
                $("input[name=Id]").val(data.person.id);
                $("input[name=Name]").val(data.person.name).parent().addClass("focused");
                $("input[name=EmailAddress]").val(data.person.emailAddress).parent().addClass("focused");
                $("input[name=PhoneNumber]").val(data.person.phoneNumbers[0].number).parent().addClass("focused");
                $("select[name=PhoneNumberType]").selectpicker('val', data.person.phoneNumbers[0].phoneType);
                $("input[name=Address]").val(data.person.address).parent().addClass("focused");
            })
        });

        $("#PersonCreateModal").on("hide.bs.modal", function () {
            _$form[0].reset();
        })

    });
})();