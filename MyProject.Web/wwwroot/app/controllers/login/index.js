var loginController = function () {
	this.initialize = function () {

	}
	var registerEvents = function () {
		$('#btnLogin'), on('click', function (e) {
			e.preventDefault();
			var user = $('#userName').val();
			var pass = $('#password').val();
			login(user, pass);
		});
	},
	var login = function (user, pass) {
		$.ajax({
			type: "post",
			data: {
				userName: user,
				password: pass
			},
			dataType: 'json',
			url: '/admin/login/authen',
			success: function (res) {
				if (res.success) {
					window.location.href = "/Admin/Home/Login";
				} else {
					myWebsite.notify('Login fail!');
				}
			}
		})
	}
}