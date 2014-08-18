SmartTracking
=============

ASP.NET MVC 版访客追踪

用法示例
=============

'''
<script type="text/javascript">
	var _maq = _maq || [];
	_maq.push(['_setAccount', 'SmartTracking']);
	_maq.push(['_trackPageview']);
	_maq.push(['_trackSubmit']);
	_maq.push(['_trackClick']);
	_maq.push(['_trackMover']);

	(function () {
		var ma = document.createElement('script'); ma.type = 'text/javascript'; ma.async = true;
		ma.src = ('https:' == document.location.protocol ? 'https://' : 'http://') + 'localhost:50374/ma.js';
		var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ma, s);
	})();
</script>
'''
