jQuery(document).ready(function ($) {
    $(window).on('load', function () {
        setTimeout(function () {
            $('.preloader').fadeOut().end().delay(500).fadeOut('slow');
        }, 1000);
    });
    $('.product-item__toggle button').on('click', function () {
        $(this).offsetParent('.product-item').find('.product-item__active').toggleClass('is-show');
        $(this).parent('.product-item__toggle').toggleClass('is-show');
    });
    $('.product-item__whish').on('click', function () {
        $(this).toggleClass('is-active');
    });
    $('.product-full-card__toggle button').on('click', function () {
        $(this).offsetParent('.product-full-card').find('.product-full-card__active').toggleClass('is-show');
        $(this).parent('.product-full-card__toggle').toggleClass('is-show');
    });
    $('.product-full-card__whish').on('click', function () {
        $(this).toggleClass('is-active');
    });
    $('.counter .minus').on('click', function () {
        var $input = $(this).parent().find('input');
        var count = parseInt($input.val()) - 1;
        count = count < 1 ? 1 : count;
        $input.val(count);
        $input.change();
        return false;
    });
    $('.counter .plus').on('click', function () {
        var $input = $(this).parent().find('input');
        $input.val(parseInt($input.val()) + 1);
        $input.change();
        return false;
    });
    $('.js-hidden-box').each(function () {
        $(this).children('div').hide();
        $(this).children('div').slice(0, 6).show();
        $(this).next('.js-hidden-btn').on('click', function (e) {
            e.preventDefault();
            $(this).prev('.js-hidden-box').children('div:hidden').slice(0, 3).slideDown();
            var elHidden = $(this).prev('.js-hidden-box').children('div:hidden').length;

            if (elHidden <= 0) {
                $(this).hide();
            }
        });
    });
    $('.js-checkbox').on('click', function () {
        $(this).toggleClass('is-checked');
    });
});
var options = {
    light: "light.css",
    dark: "dark.css",
    startAt: "21:00",
    endAt: "09:00",
    checkSystemScheme: true,
    saveOnToggle: true
};

var DarkMode = new DarkMode(options); // Function for `mode-toggler` button

var ModeToggler = document.getElementById('mode-toggler');
changeTogglerText();

ModeToggler.onclick = function () {
    DarkMode.toggleMode();
    changeTogglerText();
}; // Changes `mode-toggler` text on mode changing




/////////////////////////////////////////////////////////////////
// Preloader
/////////////////////////////////////////////////////////////////


var $preloader = $('#page-preloader'),
    $spinner = $preloader.find('.spinner-loader');
$spinner.fadeOut();
$preloader.delay(50).fadeOut('slow');


function changeTogglerText() {
    var currentMode = DarkMode.getMode();
    ModeToggler.classList = currentMode === 'light' ? 'dark' : 'light';
}

const mediaQueryTablet = window.matchMedia('(max-width: 768px)');

function handleTabletChange(e) {
    if (e.matches) {
        console.log('Media Query 768!');
    }
}

mediaQueryTablet.addListener(handleTabletChange);
handleTabletChange(mediaQueryTablet);