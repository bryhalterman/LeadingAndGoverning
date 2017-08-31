/// <reference path="D:\Git\LeadingAndGoverning\LeadingAndGoverning\LeadingAndGoverning\Shared/Footer.html" />
/// <reference path="D:\Git\LeadingAndGoverning\LeadingAndGoverning\LeadingAndGoverning\Shared/Header.html" />
/// <reference path="D:\Git\LeadingAndGoverning\LeadingAndGoverning\LeadingAndGoverning\Shared/Navigation.html" />
var paths = {
    header: "/Shared/Header.html",
    footer: "/Shared/Footer.html"
};

$(document).ready(function () {
    // Load Header
    $("header").load(paths.header);
    $("header").data("welcome").parent().addClass("active")
    // Load Footer
    $("footer").load(paths.footer);
    site.loadContent();
});

var site = {
    loadContent: function () {
        $("nav").first
    },
};