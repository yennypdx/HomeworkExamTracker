import axios from 'axios';

export const GET_ALL_HOMEWORK_REQUEST = 'GET_ALL_HOMEWORK_REQUEST';
export const GET_ALL_HOMEWORK_SUCCESS = 'GET_ALL_HOMEWORK_SUCCESS';
export const GET_ALL_HOMEWORK_ERROR = 'GET_ALL_HOMEWORK_ERROR';

const getHomeworkSuccess = payload => ({
    type: GET_ALL_HOMEWORK_SUCCESS,
    payload
});

const getHomeworkError = payload => ({
    type: GET_ALL_HOMEWORK_ERROR,
    payload
});

export const getAllHomework = () => dispatch => {
    dispatch({type: GET_ALL_HOMEWORK_REQUEST});

    return axios.get('api/Homework/get/hwlist/{id}').then(resp => {
        const response = resp.data;
        dispatch(getHomeworkSuccess(response));

    }).catch(error => {
        dispatch(getHomeworkError("Something went wrong!"));
        return Promise.reject({});
    })
}