# RIA2.frontend

## Description

This project is a front end made in vue and vuetify, that works with calling API's.

## Getting Started

### Prerequisites

Make sure you have yarn installed in your computer, if not, install it https://classic.yarnpkg.com/lang/en/docs/install/#windows-stable.

#### Environment

- IDE (Visual Code studio).
- Node.js (v20.9).
- OS (windows 10, not tested under other OS).

#### Libraries

you can find the complete list in the package.json file, at the frontend folder root.

##### Prod
    "core-js": "^3.8.3",
    "cypress-file-upload": "^5.0.8",
    "vue": "^3.2.13",
    "vue-i18n": "^9.9.1",
    "vuetify": "^3.5.4"

##### Dev
    "@babel/core": "^7.12.16",
    "@babel/eslint-parser": "^7.12.16",
    "@cucumber/cucumber": "^10.3.1",
    "@vue/cli-plugin-babel": "~5.0.0",
    "@vue/cli-plugin-e2e-cypress": "~5.0.0",
    "@vue/cli-plugin-eslint": "~5.0.0",
    "@vue/cli-plugin-unit-jest": "~5.0.0",
    "@vue/cli-service": "~5.0.0",
    "@vue/test-utils": "^2.0.0-0",
    "@vue/vue3-jest": "^27.0.0-alpha.1",
    "babel-jest": "^27.0.6",
    "cypress": "^9.7.0",
    "cypress-cucumber-preprocessor": "^4.3.1",
    "eslint": "^7.32.0",
    "eslint-config-prettier": "^8.3.0",
    "eslint-plugin-prettier": "^4.0.0",
    "eslint-plugin-vue": "^8.0.3",
    "jest": "^27.0.5",
    "prettier": "^2.4.1"

### Application configuration

With yarn, run yarn

### Database configuration

just run the Create_database.sql under the sql folder

## Deployment

### Dev environment

With visual studio community, you only need to build the application within visual studio and for the tests, it's fairly simple too, just run them

### integration environment

Go over github packages, and download the latest executable, and put it on the prod environment

#### building

Tests mustn't be build, so, you must only build "VisitionTest", from the main branch, put it on github packages and then correctly version it, with a changelog, explaining what has been added, change, and removed, this should reflect the doc too

## Directory tree
    VisionTest
    ├───Analysers
    ├───Database
    ├───Datas
    ├───Exceptions
    ├───Interfaces
    VisionTestTests

## Collaborate

If you wish to collaborate, simply clone the repo, create a branch with the feature you want to fix, or add.

When you're finish with it, create a pull request, we will review your code, comment it, and it will be merged once it passes our requirements.

For more info please check the wiki

## License

Unlicensed, Available at project root

## Contact

If you have any problems, please reach us on github issues
