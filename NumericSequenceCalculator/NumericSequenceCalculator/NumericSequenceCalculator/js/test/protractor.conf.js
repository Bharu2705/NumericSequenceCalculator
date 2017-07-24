/*
 * Protractor Config
 */

exports.config = {
    specs: ['./e2e/**/*.spec.js'],

    baseUrl: 'http://localhost:63126',

    //For testing with multiple browsers at once
    //multiCapabilities: [{
    //    browserName: 'firefox'
    //}, {
    //    browserName: 'chrome'
    //}]
};