document.addEventListener('DOMContentLoaded', function ()
{
    document.querySelector('button').addEventListener('click', main);      
	$(document).on('click','input[type=text]',function(){ this.select(); });
	$("#master").select();
});

chrome.tabs.query({'active': true, 'windowId': chrome.windows.WINDOW_ID_CURRENT},
	function(tabs){
		var urlString = tabs[0].url;
		var siteName = getSite(getLocation(urlString).host);
		$("#plaintext").prop("value",siteName);
	}
);

function getLocation(href)
{
    var match = href.match(/^(https?\:)\/\/(([^:\/?#]*)(?:\:([0-9]+))?)(\/[^?#]*)(\?[^#]*|)(#.*|)$/);
    return match && {
        protocol: match[1],
        host: match[2],
        hostname: match[3],
        port: match[4],
        pathname: match[5],
        search: match[6],
        hash: match[7]
    }
}

function getSite(host)
{
	var arr = host.split(".");
	return arr.length == 2 ? arr[0] : arr[1];
}

function main()
{
	var master = $("#master").prop("value");
	var plaintext = $("#plaintext").prop("value");
	var result = Tea.encrypt(plaintext, master);
	$("#encrypted").prop( "value", result );
	$('input[type=text]').select();
};
