﻿var myWebsite = {
	configs: {
		pageSize: 10,
		pageIndex: 1
	},
	notify: function (message, type) {
		$.notify(message, {
			// whether to hide the notification on click
			clickToHide: true,
			// whether to auto-hide the notification
			autoHide: true,
			// if autoHide, hide after milliseconds
			autoHideDelay: 5000,
			// show the arrow pointing at the element
			arrowShow: true,
			// arrow size in pixels
			arrowSize: 5,
			// position defines the notification position though uses the defaults below
			position: '...',
			// default positions
			elementPosition: 'top right',
			globalPosition: 'top right',
			// default style
			style: 'bootstrap',
			// default class (string or [string])
			className: type,
			// show animation
			showAnimation: 'slideDown',
			// show animation duration
			showDuration: 400,
			// hide animation
			hideAnimation: 'slideUp',
			// hide animation duration
			hideDuration: 200,
			// padding between element and notification
			gap: 2
		});
	},
	confirm: function (message, okCallBack) {
		bootbox.confirm({
			message: message,
			buttons: {
				confirm: {
					label: 'Yes',
					className: 'btn-success'
				},
				cancel: {
					label: 'No',
					className: 'btn-danger'
				} 
			},
			callback: function (result) {
				if (result === true) {
					okCallBack();
				}
			}
		});
	},
	dateFormatJson: function (datetime) {
		// Kiểm tra null hoặc empty
		if (datetime == null || datetime == '') return '';

		try {
			// Chỉ lấy số từ chuỗi /Date(...)/ của .NET
			var newdate = new Date(parseInt(datetime.substr(6)));

			// Kiểm tra date có hợp lệ không
			if (isNaN(newdate.getTime())) return '';

			var month = newdate.getMonth() + 1;
			var day = newdate.getDate();
			var year = newdate.getFullYear();
			var hh = newdate.getHours();
			var mm = newdate.getMinutes();

			// Thêm số 0 phía trước nếu cần
			if (month < 10) month = "0" + month;
			if (day < 10) day = "0" + day;
			if (hh < 10) hh = "0" + hh;
			if (mm < 10) mm = "0" + mm;

			return day + "/" + month + "/" + year;
		} catch (error) {
			return '';
		}
	},
	startLoading: function () {
		if ($('.div-loading').length > 0) {
			$('.div-loading').removeClass('hide');
		}
	},
	stopLoading: function () {
		if ($('.div-loading').length > 0) {
			$('.div-loading').addClass('hide');
		}
	},
	getStatus: function (status) {
		if (status == 1) {
			return '<span class="badge bg-green">Activate</span>';
		}
		return '<span class="badge bg-red">Block</span>';
	},
	formatNumber: function (number, precision) {
		if (!isFinite(number)) {
			return number.toString();
		}
		var a = number.toFixed(precision).split('.');
		a[0] = a[0].replace(/\d(?=(\d{3})+$)/g, `$&,`);
		return a.join(`.`);
	},
	unflattern: function (arr) {
		var map = {};
		var roots = [];
		for (var i = 0; i < arr.length; i++) {
			var node = arr[i];
			node.children = [];
			map[node.Id] = i;
			if (node.ParentId != null) {
				arr[map[node.ParentId]].children.push(node);
			} else {
				roots.push(node);
			}
		}
		return roots;
	}
}