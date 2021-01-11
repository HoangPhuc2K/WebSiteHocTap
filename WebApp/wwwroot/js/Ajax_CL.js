function DeleteStudentApi(id) {
    if (confirm('Bạn có muốn xóa học sinh này ?')) {
        $.ajax({
            type: 'DELETE',
            url: '../API/StudentAPI/DeleteStudentModel/' + id,
        })
            .done(function (res) {
                var html = '<tbody id="AllStudent">';
                data = res;
                for (i = 0; i < data.length; i++) {
                    html += ' <tr>';
                    html += ' <td>';
                    html += ' ' + data[i].fullName;
                    html += ' </td>';
                    html += ' <td>';
                    html += ' ' + data[i].email;
                    html += ' </td>';
                    html += ' <td>';
                    html += ' ' + data[i].address;
                    html += ' </td>';
                    html += ' <td>';
                    html += ' ' + data[i].phone;
                    html += ' </td>';
                    html += ' <td>';
                    html += ' ' + data[i].idUser;
                    html += ' </td>';
                    html += ' <td>';
                    html += '<a class=\"btn btn-warning\" onclick=\"showInPopup(\'https://localhost:44379/Admin/Student/AddOrEdit/' + data[i].id + '\',\'Chỉnh sửa\')\" > Chỉnh Sửa</a >| ';
                    html += '<button class=\"btn btn-warning\" onclick=\"DeleteStudentApi(' + data[i].id + ')\"> Xóa </button>'
                    html += ' </td>';
                    html += ' </tr>';
                }
                html += ' </tbody>';
                document.getElementById('AllStudent').innerHTML = html;

                $.ajax({
                    type: 
                })
            })
    }
}