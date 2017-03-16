var Animal = (function () {
    function Animal(species) {
        this.species = species;
    }
    Animal.prototype.speak = function () {
        $.each($('.class'), function () {
            $(this).val('');
        });
        alert('I am a ss' + this.species);
    };
    return Animal;
}());
