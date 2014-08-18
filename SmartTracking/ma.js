/*

<script type="text/javascript">
	var _maq = _maq || [];
	_maq.push(['_setAccount', '88mf.com']);
	_maq.push(['_trackPageview']);
	_maq.push(['_trackSubmit']);
	_maq.push(['_trackClick']);
	_maq.push(['_trackMover']);
	 
	(function() {
		var ma = document.createElement('script'); ma.type = 'text/javascript'; ma.async = true;
		ma.src = ('https:' == document.location.protocol ? 'https://a' : 'http://a') + '.tjrubik.com/ta.js';
		var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ma, s);
	})();
</script>

*/

(function () {

	var params = {};
	var exts   = ''; 
	var mbuffer= [];

	if(document) {
	    params.Domain = document.domain || '';
		params.Uri = document.URL || '';
		params.Referrer = document.referrer || '';
	}
	if(window && window.screen) {
	    params.ScreenWidth = window.screen.height || 0;
	    params.ScreenHeight = window.screen.width || 0;
	    params.ColorDepth = window.screen.colorDepth || 0;
	}
	if(navigator) {
		params.lang = navigator.language || '';
	}
	if(_maq) {
		for(var i in _maq) {
			switch(_maq[i][0]) {
			case '_setAccount':
			    params.Account = _maq[i][1];
				break;
			case '_trackPageview':
			    params.Event = '_trackPageview';
				dosubmit();
				break;	
			case '_trackSubmit':
				var list = document.getElementsByTagName("INPUT");
				for (var i=0; i<list.length; i++) {
					if ( list[i].type.toUpperCase() == 'SUBMIT' || list[i].type.toUpperCase() == 'BUTTON') {
						if (list[i].addEventListener) {
							list[i].addEventListener("mousedown", docollect, false);
						} else {
							list[i].attachEvent("onmousedown", docollect);
						}
					}
				}
				break;
			case '_trackClick':
				if (document.addEventListener) {
					document.addEventListener("mousedown", doclick, false);
				} else {
					document.attachEvent("onmousedown", doclick);
				}
				break;
			 case '_trackMover':
				if (document.addEventListener) {
					document.addEventListener("mouseover", domover, false);
				} else {
					document.attachEvent("onmouseover", domover);
				}
				break;
			default:
				break;
			}
		}
	}

	function doclick(event) {
		event = event? event: window.event;
		params.Exts = event.clientX + '|' + event.clientY + '|';
		params.Event = '_trackClick';
		var _userid = '';
		try {
			if (userInfo) {	_userid = userInfo.id; }
		}catch(e){}
		
		if(event.target) {
			if(event.target.tagName.toUpperCase()=="A"){
			    params.Exts += event.target.getAttribute("href");
			}
		} else {
			if(event.srcElement.tagName.toUpperCase()=="A"){
			    params.Exts += event.srcElement.getAttribute("href");
			}
		}
		
		if (_userid != '') { params.Exts += '|' + _userid; }
		
		dosubmit();
	}

	function domover(event) {
		event = event? event: window.event;
		mbuffer.push(event.clientX + ',' + event.clientY);
		if ( mbuffer.length >= 20 ) {
		    params.Event = '_trackMover';
			params.Exts = mbuffer.join('|');
			mbuffer = [];
			dosubmit();
		}
	}

	function docollect() {
	    params.Exts = '';
	    params.Event = '_trackSubmit';
		var list = document.getElementsByTagName("INPUT");
		for (var i=0; i<list.length; i++) {
			if ((list[i].type.toUpperCase() == 'TEXT' || list[i].type.toUpperCase() == 'HIDDEN') && list[i].value.length <= 32) {
			    params.Exts += list[i].value + '|';
			}
		}
		dosubmit();
	}	

	function dosubmit() {
		var args = '';
		for(var i in params) {
			if(args != '') {
				args += '&';
			}
			args += i + '=' + encodeURIComponent(params[i]);
		}
		var img = new Image(1, 1);
		img.src = 'http://localhost:50374?' + args;
	}

})();